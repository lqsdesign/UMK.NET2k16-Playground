using PSPiZK;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace ZadanieUserControlMVVM
{
    public abstract class DialogBox : FrameworkElement, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(
                propertyName));
        }
        #endregion

        protected Action<object> execute = null;
        public string Caption { get; set; } = null;
        protected ICommand show;
        public virtual ICommand Show
        {
            get
            {
                if (show == null) show = new MvvmCommand(execute);
                return show;
            }
        }
    }

    public abstract class CommandDialogBox : DialogBox
    {
        public override ICommand Show
        {
            get
            {
                if (show == null) show = new MvvmCommand(
                    o =>
                    {
                        ExecuteCommand(CommandBefore, CommandParameter);
                        execute(o);
                        ExecuteCommand(CommandAfter, CommandParameter);
                    });
                return show;
            }
        }

        public static DependencyProperty CommandParameterProperty = DependencyProperty.Register("CommandParameter", typeof(object), typeof(CommandDialogBox));

        public object CommandParameter
        {
            get
            {
                return GetValue(CommandParameterProperty);
            }
            set
            {
                SetValue(CommandParameterProperty, value);
            }
        }

        protected static void ExecuteCommand(ICommand command, object commandParameter)
        {
            if (command != null)
                if (command.CanExecute(commandParameter))
                    command.Execute(commandParameter);
        }

        public static DependencyProperty CommandBeforeProperty = DependencyProperty.Register("CommandBefore", typeof(ICommand), typeof(CommandDialogBox));

        public ICommand CommandBefore
        {
            get
            {
                return (ICommand)GetValue(CommandBeforeProperty);
            }
            set
            {
                SetValue(CommandBeforeProperty, value);
            }
        }

        public static DependencyProperty CommandAfterProperty = DependencyProperty.Register("CommandAfter", typeof(ICommand), typeof(CommandDialogBox));

        public ICommand CommandAfter
        {
            get
            {
                return (ICommand)GetValue(CommandAfterProperty);
            }
            set
            {
                SetValue(CommandAfterProperty, value);
            }
        }
    }

    public abstract class FileDialogBox : CommandDialogBox
    {
        public bool? FileDialogResult { get; protected set; }
        public string FilePath { get; set; }
        public string Filter { get; set; }
        public int FilterIndex { get; set; }
        public string DefaultExt { get; set; }

        protected Microsoft.Win32.FileDialog fileDialog = null;

        protected FileDialogBox()
        {
            execute =
                o =>
                {
                    fileDialog.Title = Caption;
                    fileDialog.Filter = Filter;
                    fileDialog.FilterIndex = FilterIndex;
                    fileDialog.DefaultExt = DefaultExt;
                    string filePathString = "";
                    if (FilePath != null) filePathString = FilePath; else FilePath = "";
                    if (o != null) filePathString = (string)o;
                    if (!string.IsNullOrWhiteSpace(filePathString))
                    {
                        fileDialog.InitialDirectory = System.IO.Path.GetDirectoryName(filePathString);
                        fileDialog.FileName = System.IO.Path.GetFileName(filePathString);
                    }
                    FileDialogResult = fileDialog.ShowDialog();
                    OnPropertyChanged("FileDialogResult");
                    if (FileDialogResult.HasValue && FileDialogResult.Value)
                    {
                        FilePath = fileDialog.FileName;
                        OnPropertyChanged("FilePath");
                        ExecuteCommand(CommandFileOk, FilePath);
                    };
                };
        }

        public static DependencyProperty CommandFileOkProperty = DependencyProperty.Register("CommandFileOk", typeof(ICommand), typeof(FileDialogBox));

        public ICommand CommandFileOk
        {
            get
            {
                return (ICommand)GetValue(CommandFileOkProperty);
            }
            set
            {
                SetValue(CommandFileOkProperty, value);
            }
        }
    }

    public class OpenFileDialogBox : FileDialogBox
    {
        public OpenFileDialogBox()
        {
            fileDialog = new Microsoft.Win32.OpenFileDialog();
        }
    }
}
