using Microsoft.WindowsAPICodePack.Dialogs;
using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GhostModeToogle_Click(object sender, RoutedEventArgs e)
        {
            if(GhostModeToogle.IsChecked.Value)
            {
                GhostModeText.Text = "Save";
            } else
            {
                GhostModeText.Text = "Reproduce";
            }
        }

        private void RunButton_Click(object sender, RoutedEventArgs e)
        {
            // Inject the DLL
        }

        private void SaveLoadFolderButton_Click(object sender, RoutedEventArgs e)
        {
            // Load SaveLoad folder
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SaveLoadTxt.Text = dialog.FileName;
            }
        }

        private void TRFolderButton_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                //Check Tomb2.exe exists.
                TRFolderTxt.Text = dialog.FileName;
            }
        }
    }
}
