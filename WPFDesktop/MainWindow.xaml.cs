﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFDesktop.Utils;
using WPFDesktop.Forms;

namespace WPFDesktop
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

            AnswerGenerator answerGenerator = new AnswerGenerator();
            tbxAnswer.Text = answerGenerator.GetRandomAnswer(tbxQuestion.Text);
            this.Cursor = null;
        }

        private void btnOpenPage_Click(object sender, RoutedEventArgs e)
        {
            this.Cursor = Cursors.Wait;
            System.Windows.MessageBox.Show("加载中······");
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            EightBallBrowserPage eightBallBrowserPage = new EightBallBrowserPage();
            eightBallBrowserPage.ShowDialog();
        }
    }
}
