using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using Skork_Engine_Library.Draw;
using Skork_Engine_Library.Parse;
using SkorkEngine.Service;

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
            SkorkPlane plane = new SkorkPlane
            {
                ColorPrimary = Colors.Black,
                ColorSecondary = Colors.White,
                Height = (int)richTextCode.ActualHeight,
                Width = (int)richTextCode.ActualWidth,
            };

            GeneratePlane.GenerateSingleGrid(plane);
            var imgBrush = new ImageBrush
            {
                ImageSource = plane.Image
            };

            gridPlaneInner.Background = imgBrush;
        }

        private void MenuCustom_Click(object sender, RoutedEventArgs e)
        {
            SkorkPlane plane = new SkorkPlane
            {
                ColorPrimary = Colors.Black,
                ColorSecondary = Colors.White,
                Height = (int)richTextCode.ActualHeight,
                Width = (int)richTextCode.ActualWidth,
            };

            TextRange range = new TextRange(richTextCode.Document.ContentStart, richTextCode.Document.ContentEnd);
            string[] lines = range.Text.Split('\n');

            string typeAsString = string.Empty;

            foreach (var line in lines)
            {
                if (line.StartsWith("$"))
                {
                    typeAsString = line.Substring(1);
                }
            }
            var invokeMethodString = new Action(() =>
            {
                GeneratePlane genplane = new GeneratePlane();
                Type generatePlaneType = Type.GetType(typeAsString);
                MethodInfo generatePlaneMethod = generatePlaneType.GetMethod(typeAsString);
                generatePlaneMethod.Invoke(genplane, new object[] { plane });
            });

            invokeMethodString.Invoke();

            MessageBox.Show(typeAsString);

            GeneratePlane.GenerateDoubleGrid(plane);
            var imgBrush = new ImageBrush
            {
                ImageSource = plane.Image
            };

            gridPlaneInner.Background = imgBrush;
        }
    }
}
