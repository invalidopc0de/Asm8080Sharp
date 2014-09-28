using Asm8080Sharp;
using Asm8080Sharp.Instructions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Asm8080Metro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        StorageFile m_currentFile;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnAssemble_Click(object sender, RoutedEventArgs e)
        {
            AsmParser parser = new AsmParser();
            List<AbstractInstruction> machineCode = new List<AbstractInstruction>();
            machineCode = parser.parseAsm(this.txtAssembly.Text);
            this.txtMachineCode.Text = "";
            foreach (AbstractInstruction instruction in machineCode)
            {
                this.txtMachineCode.Text += instruction.getBinaryCode() + Environment.NewLine;
            }
        }

        async private void abbOpen_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            openPicker.FileTypeFilter.Add(".s");

            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                this.txtAssembly.Text = await Windows.Storage.FileIO.ReadTextAsync(file);
            }
        }

        async private void abbSave_Click(object sender, RoutedEventArgs e)
        {
            if (m_currentFile == null)
            {
                FileSavePicker savePicker = new FileSavePicker();
                savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
                savePicker.DefaultFileExtension = ".s";
                savePicker.FileTypeChoices.Add("Assembly Source File", new List<string>() { ".s" });

                StorageFile file = await savePicker.PickSaveFileAsync();
                if (file != null)
                {
                    // Application now has read/write access to the picked file
                    m_currentFile = file;
                }
            }

            if (m_currentFile != null)
            {
                await Windows.Storage.FileIO.WriteTextAsync(m_currentFile, this.txtAssembly.Text);
            }
        }
    }
}
