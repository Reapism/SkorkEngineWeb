using Skork.Window.Draw.Plane;
using SkorkEngine.Service;
using SkorkEngine.UIService;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace SkorkEngine.GUI
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

        private void MenuCompile_Click(object sender, RoutedEventArgs e)
        {
            int i = CompileService.CompileCode(CompileService.ConvertCodeIntoList(ref richTextCode));
            MessageBox.Show(i.ToString());
        }

        private void MenuClean_Click(object sender, RoutedEventArgs e)
        {
            List<string> code = CompileService.ConvertCodeIntoList(ref richTextCode);

            foreach (string s in code)
            {
                MessageBox.Show(s);
            }
        }

        private void MenuParse_Click(object sender, RoutedEventArgs e)
        {
            GeneratePlane.GenerateSingleGrid(SkorkPlanePropertiesService.Instance);
            ImageBrush imgBrush = new ImageBrush
            {
                ImageSource = SkorkPlanePropertiesService.Instance.Image
            };

            gridPlaneInner.Background = imgBrush;
        }

        private void MenuCustom_Click(object sender, RoutedEventArgs e)
        {
            TextRange range = new TextRange(richTextCode.Document.ContentStart, richTextCode.Document.ContentEnd);
            string[] lines = range.Text.Split('\n');

            string typeAsString = string.Empty;

            foreach (string line in lines)
            {
                if (line.StartsWith("$"))
                {
                    typeAsString = line.Substring(1);
                }
            }
            Action invokeMethodString = new Action(() =>
            {
                GeneratePlane genplane = new GeneratePlane();
                Type generatePlaneType = Type.GetType(typeAsString);
                MethodInfo generatePlaneMethod = generatePlaneType.GetMethod(typeAsString);
                generatePlaneMethod.Invoke(genplane, new object[] { SkorkPlanePropertiesService.Instance });
            });

            invokeMethodString.Invoke();

            MessageBox.Show(typeAsString);

            GeneratePlane.GenerateDoubleGrid(SkorkPlanePropertiesService.Instance);
            ImageBrush imgBrush = new ImageBrush
            {
                ImageSource = SkorkPlanePropertiesService.Instance.Image
            };

            gridPlaneInner.Background = imgBrush;
        }
    }
}
