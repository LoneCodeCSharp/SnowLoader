using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SnowLoader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            var dispatcherTimer1 = new System.Windows.Threading.DispatcherTimer();
            var dispatcherTimer3 = new System.Windows.Threading.DispatcherTimer();
            var dispatcherTimer2 = new System.Windows.Threading.DispatcherTimer();
            var dispatcherTimer4 = new System.Windows.Threading.DispatcherTimer();
            var dispatcherTimer5 = new System.Windows.Threading.DispatcherTimer();

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer1.Tick += new EventHandler(dispatcherTimer_Tick1);
            dispatcherTimer2.Tick += new EventHandler(dispatcherTimer_Tick2);
            dispatcherTimer3.Tick += new EventHandler(dispatcherTimer_Tick3);
            dispatcherTimer4.Tick += new EventHandler(dispatcherTimer_Tick4);
            dispatcherTimer5.Tick += new EventHandler(dispatcherTimer_Tick5);

            dispatcherTimer.Interval = new TimeSpan(0,0,5);
            dispatcherTimer1.Interval = new TimeSpan(0, 0, 6);
            dispatcherTimer2.Interval = new TimeSpan(0, 0, 7);
            dispatcherTimer3.Interval = new TimeSpan(0, 0, 8);
            dispatcherTimer4.Interval = new TimeSpan(0, 0, 9);
            dispatcherTimer5.Interval = new TimeSpan(0, 0, 7);

            dispatcherTimer.Start();
            dispatcherTimer1.Start();
            dispatcherTimer2.Start();
            dispatcherTimer3.Start();
            dispatcherTimer4.Start();
            dispatcherTimer5.Start();




        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            FallingsSnowflake(0, 2, -200, -10, 0, 0, -200, 230, 0, 0, sn1, 1000);
            FallingsSnowflake(0, 2.5, 200, -10, 0, 0, 200, 230, 0, 0, sn2, 1000);
            FallingsSnowflake(0, 3, -140, -50, 0, 0, -140, 230, 0, 0, sn3, 1000);
            FallingsSnowflake(0, 3.5, 140, -70, 0, 0, 150, 230, 0, 0, sn4, 2000);
            FallingsSnowflake(0, 4, 80, -90, 0, 0, 80, 230, 0, 0, sn5, 2200);
            FallingsSnowflake(0, 5, -80, -100, 0, 0, -80, 230, 0, 0, sn6, 2000);
            FallingsSnowflake(0, 2.5, 0, -80, 0, 0, 0, 230, 0, 0, sn31, 2000);
   
        }
        private void dispatcherTimer_Tick1(object sender, EventArgs e)
        {
            FallingsSnowflake(0, 2, -200, -10, 0, 0, -200, 230, 0, 0, sn7, 1000);
            FallingsSnowflake(0, 2.5, 200, -10, 0, 0, 200, 230, 0, 0, sn8, 1000);
            FallingsSnowflake(0, 3, -140, -50, 0, 0, -140, 230, 0, 0, sn9, 1000);
            FallingsSnowflake(0, 3.5, 140, -70, 0, 0, 150, 230, 0, 0, sn10, 2000);
            FallingsSnowflake(0, 4, 80, -90, 0, 0, 80, 230, 0, 0, sn11, 2200);
            FallingsSnowflake(0, 5, -80, -100, 0, 0, -80, 230, 0, 0, sn12, 2000);
            FallingsSnowflake(0, 2.5, 0, -80, 0, 0, 0, 230, 0, 0, sn32, 2000);
 
        }
        private void dispatcherTimer_Tick3(object sender, EventArgs e)
        {
            FallingsSnowflake(0, 2, -200, -10, 0, 0, -200, 230, 0, 0, sn13, 1000);
            FallingsSnowflake(0, 2.5, 200, -10, 0, 0, 200, 230, 0, 0, sn14, 1000);
            FallingsSnowflake(0, 3, -140, -50, 0, 0, -140, 230, 0, 0, sn15, 1000);
            FallingsSnowflake(0, 3.5, 140, -70, 0, 0, 150, 230, 0, 0, sn16, 2000);
            FallingsSnowflake(0, 4, 80, -90, 0, 0, 80, 230, 0, 0, sn17, 2200);
            FallingsSnowflake(0, 5, -80, -100, 0, 0, -80, 230, 0, 0, sn18, 2000);
            FallingsSnowflake(0, 2.5, 0, -80, 0, 0, 0, 230, 0, 0, sn33, 2000);
          
        }
        private void dispatcherTimer_Tick2(object sender, EventArgs e)
        {
            FallingsSnowflake(0, 2, -200, -10, 0, 0, -200, 230, 0, 0, sn19, 1000);
            FallingsSnowflake(0, 2.5, 200, -10, 0, 0, 200, 230, 0, 0, sn20, 1000);
            FallingsSnowflake(0, 3, -140, -50, 0, 0, -140, 230, 0, 0, sn21, 1000);
            FallingsSnowflake(0, 3.5, 140, -70, 0, 0, 150, 230, 0, 0, sn22, 2000);
            FallingsSnowflake(0, 4, 80, -90, 0, 0, 80, 230, 0, 0, sn23, 2200);
            FallingsSnowflake(0, 5, -80, -100, 0, 0, -80, 230, 0, 0, sn24, 2000);
            FallingsSnowflake(0, 2.5, 0, -80, 0, 0, 0, 230, 0, 0, sn34, 2000);
          
        }
        private void dispatcherTimer_Tick4(object sender, EventArgs e)
        {
            FallingsSnowflake(0, 2, -200, -10, 0, 0, -200, 230, 0, 0, sn25, 1000);
            FallingsSnowflake(0, 2.5, 200, -10, 0, 0, 200, 230, 0, 0, sn26, 1000);
            FallingsSnowflake(0, 3, -140, -50, 0, 0, -140, 230, 0, 0, sn27, 1000);
            FallingsSnowflake(0, 3.5, 140, -70, 0, 0, 150, 230, 0, 0, sn28, 2000);
            FallingsSnowflake(0, 4, 80, -90, 0, 0, 80, 230, 0, 0, sn29, 2200);
            FallingsSnowflake(0, 5, -80, -100, 0, 0, -80, 230, 0, 0, sn30, 2000);
            FallingsSnowflake(0, 2.5, 0, -80, 0, 0, 0, 230, 0, 0, sn35, 2000);
          
        }

        private void dispatcherTimer_Tick5(object sender, EventArgs e)
        {
           Snow(0, 6, 0, -3, 0, 0, 0, -30, 0, 0, snd1);
           Snow(0, 6, 30, -2, 0, 0, 30, -27, 0, 0, snd2);
           Snow(0, 6, 0, -3, 35, 0, 0, -32, 35, 0, snd3);
           Snow(0, 6, -60, -1, 0, 0, -60, -15, 0, 0, snd4);
           Snow(0, 6, 0, -1, -60, 0, 0, -15, -60, 0, snd5);


        }

        public void FallingsSnowflake(double kt1, double kt2, int left1, int top1, int right1, int bottom1, int left2, int top2, int right2, int bottom2, Ellipse ellipse, int td)
        {


            Dispatcher.Invoke((Action)(() =>
            {
                ThicknessAnimationUsingKeyFrames usingKeyFrames = new ThicknessAnimationUsingKeyFrames();
                KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(kt1));
                KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(kt2));
                Thickness thickness1 = new Thickness(left1, top1, right1, bottom1);
                Thickness thickness2 = new Thickness(left2, top2, right2, bottom2);
                usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
                usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
                ellipse.BeginAnimation(MarginProperty, usingKeyFrames);

            }));
             
        }
        public void Snow(double kt1, double kt2, int left1, int top1, int right1, int bottom1, int left2, int top2, int right2, int bottom2, Ellipse ellipse)
        {


            Dispatcher.Invoke((Action)(() =>
            {
                ThicknessAnimationUsingKeyFrames usingKeyFrames = new ThicknessAnimationUsingKeyFrames();
                KeyTime keyTime1 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(kt1));
                KeyTime keyTime2 = KeyTime.FromTimeSpan(TimeSpan.FromSeconds(kt2));
                Thickness thickness1 = new Thickness(left1, top1, right1, bottom1);
                Thickness thickness2 = new Thickness(left2, top2, right2, bottom2);
                usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness1, keyTime1));
                usingKeyFrames.KeyFrames.Add(new SplineThicknessKeyFrame(thickness2, keyTime2));
                ellipse.BeginAnimation(MarginProperty, usingKeyFrames);

            }));

        }

    }
           
            
        }

