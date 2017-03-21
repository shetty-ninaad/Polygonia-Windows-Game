using System;
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

namespace Polygonia
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        static int ctr = 2, pl1 = 0, pl2 = 0;
        static int[] tri = new int[70];
        static int psn = 0, scor = 0, prv = 0;
        static int[] mark = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
            0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,};
       
        public Page2()
        {
            InitializeComponent();
        }
        private void pro()
        {
            int i, j, k,x,l=0,y,a,b, flg1 = 0, flg2 = 0;
            int[,] arr = new int[,] {
                {1,2,6,7,0,0,0},{2,7,1,3,8,0,0},{3,8,2,4,9,0,0},
                {4,9,3,5,10,0,0},{5,4,10,0,0,0,0},{6,11,1,7,0,0,0},
                {7,11,6,1,2,8,12},{8,12,7,2,3,9,13},{9,13,8,3,4,10,14},
                {10,14,9,4,5,15,0},{11,16,6,7,12,17,0},{12,17,11,7,8,13,18},
                {13,18,12,8,9,14,19},{14,19,13,9,10,15,20},{15,20,14,10,0,0,0},
                {16,11,17,21,0,0,0},{17,21,16,11,12,18,22},{18,22,17,12,13,19,23},
                {19,23,18,13,14,20,24},{20,24,19,14,15,25,0},{21,16,17,22,0,0,0},
                {22,21,17,18,23,0,0},{23,22,18,19,24,0,0},{24,23,19,20,24,0,0},
                {25,24,20,0,0,0,0},
                                };
            int[] temp = new int[2];
            if (psn > 2)
                for (i = 0; i < psn; i++)
                {
                    
                    int[] arr1 = new int[3] { 0, 0, 0 };
                    int[] arr2 = new int[3] { 0, 0, 0};
                    x = 0; y = 0; a = 0; b=0;
                    flg1 = 0; flg2 = 0;

                    if (tri[i] < 100)
                    {
                        x = tri[i] % 10;
                        y = tri[i] / 10;
                    }
                    else
                    {
                        x = tri[i] % 100;
                        y = tri[i] / 100;

                    }
                    //
                    l = 0;
                    temp[0] = 0;temp[1] = 0;
                    for (j=0;j<7;j++)
                    {
                        for(k=0;k<7;k++)
                        {
                            if (arr[x-1,j]==arr[y-1,k])
                            {
                                if (arr[y-1, k] != x && arr[y-1, k] != y && l<2)
                                    temp[l] = arr[y-1, k];l++;

                            }
                        }
                    }
                        
                    a =temp[0];
                    b =temp[1];

                    
                        arr1[0] = int.Parse(x.ToString() + y.ToString());
                    if(x<a)
                        arr1[1] = int.Parse(x.ToString() + a.ToString());
                    else
                        arr1[1] = int.Parse(a.ToString() + x.ToString());
                    if (y<a)
                        arr1[2] = int.Parse(y.ToString() + a.ToString());
                    else
                        arr1[2] = int.Parse(a.ToString() + y.ToString());

                    arr2[0] = int.Parse(x.ToString() + y.ToString());
                    if(x<b)
                        arr2[1] = int.Parse(x.ToString() + b.ToString());
                    else
                        arr2[1] = int.Parse(b.ToString() + x.ToString());
                    if (y<b)
                        arr2[2] = int.Parse(y.ToString() + b.ToString());
                    else
                        arr2[2] = int.Parse(b.ToString() + y.ToString());
                    //
                    flg1 = 0;
                        for (j = 0; j < 3; j++)
                        {
                            for (k = 0; k < psn; k++)
                            {
                                if (arr1[j] == tri[k])
                                    flg1++;
                            }
                        }
                    if (flg1 >= 2)
                    {
                      
                        mark[x+y+a] = 1;
                    }

                    flg2 = 0;
                        for (j = 0; j < 3; j++)
                        {
                            for (k = 0; k < psn; k++)
                            {
                                if (arr2[j] == tri[k])
                                    flg2++;
                            }
                        }
                    if (flg2 >= 2)
                    {
                       
                        mark[x+y+b] = 1;
                    }
                    //
                    prv = scor;
                    scor = 0;
                    for (j = 0; j < 70; j++)
                        if (mark[j] == 1)
                            scor++;

                    if (ctr == 1)
                    {
                        
                        pl1 += (scor - prv);
                    }
                    else
                    {
                        
                        pl2 += (scor - prv);
                    }
                }
        }

        public static void main()
        {
            while (true)
                ;
        }

        private void button_clickexit_pg2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void onesix(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 165;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 16; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString(); 
         }

        private void twoseven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 281;
            myLine.X2 = 241;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 27; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void threeeight(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 357;
            myLine.X2 = 317;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 38; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fournine(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 357 + 76;
            myLine.X2 = 317 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 49; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fiveten(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 357 + 76 + 76;
            myLine.X2 = 317 + 76 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 510; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void elevensixteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 165;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1116; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twelveseventeen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76;
            myLine.X2 = 165 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1217; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void thirteeneighteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76;
            myLine.X2 = 165 + 76 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1318; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();

        }

        private void fourteennineteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1419; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fifteentwenty(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76 + 76 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1520; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void onetwo(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 281;
            myLine.Y1 = -72;
            myLine.Y2 = -72;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 12; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twothree(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76;
            myLine.X2 = 281 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -72;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 23; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void threefour(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76;
            myLine.X2 = 281 + 76 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -72;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 34; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fourfive(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76;
            myLine.X2 = 281 + 76 + 76 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -72;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 45; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void sixseven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76;
            myLine.X2 = 165;
            myLine.Y1 = -34;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 67; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void seveneight(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76;
            myLine.X2 = 165 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 78; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eightnine(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 89; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void nineten(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 910; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void oneseven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 241;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 17; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twoeight(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76;
            myLine.X2 = 241 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 28; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void threenine(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76;
            myLine.X2 = 241 + 76 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 39; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fourten(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76;
            myLine.X2 = 241 + 76 + 76 + 76;
            myLine.Y1 = -72;
            myLine.Y2 = -34;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 410; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void sixeleven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165;
            myLine.X2 = 205;
            myLine.Y1 = -34;
            myLine.Y2 = -8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 611; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void seventwelve(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76;
            myLine.X2 = 205 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 712; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eightthirteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76;
            myLine.X2 = 205 + 76 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 813; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void ninefourteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 914; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void tenfifteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76 + 76;
            myLine.Y1 = -34;
            myLine.Y2 = -8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1015; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void seveneleven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 241;
            myLine.X2 = 190;
            myLine.Y1 = -30;
            myLine.Y2 = 15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 711; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eighttwelve(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 241 + 76;
            myLine.X2 = 190 + 76;
            myLine.Y1 = -30;
            myLine.Y2 = 15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 812; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void ninethirteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 241 + 76 + 76;
            myLine.X2 = 190 + 76 + 76;
            myLine.Y1 = -30;
            myLine.Y2 = 15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 913; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void tenfourteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 241 + 76 + 76 + 76;
            myLine.X2 = 190 + 76 + 76 + 76;
            myLine.Y1 = -30;
            myLine.Y2 = 15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1014; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eleventwelve(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 281;
            myLine.Y1 = 8;
            myLine.Y2 = 8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1112; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twelvethirteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76;
            myLine.X2 = 281 + 76;
            myLine.Y1 = 8;
            myLine.Y2 = 8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1213; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void thirteenfourteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76;
            myLine.X2 = 281 + 76 + 76;
            myLine.Y1 = 8;
            myLine.Y2 = 8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1314; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fourteenfifteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76;
            myLine.X2 = 281 + 76 + 76 + 76;
            myLine.Y1 = 8;
            myLine.Y2 = 8;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1415; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void elevenseventeen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 165 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1117; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twelveeighteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76;
            myLine.X2 = 165 + 76 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1218; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void thirteennineteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76;
            myLine.X2 = 165 + 76 + 76 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1319; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void fourteentwenty(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76 + 76 + 76;
            myLine.Y1 = 28;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1420; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();

        }

        private void sixteenseventeen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76;
            myLine.X2 = 165;
            myLine.Y1 = 66;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1617; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void seventeeneighteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76;
            myLine.X2 = 165 + 76;
            myLine.Y1 = 66;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1718; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eighteennineteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76;
            myLine.Y1 = 66;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1819; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void nineteentwenty(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76 + 76;
            myLine.X2 = 165 + 76 + 76 + 76;
            myLine.Y1 = 66;
            myLine.Y2 = 66;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1920; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void sixteentwentyone(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 170;
            myLine.X2 = 205;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1621; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void seventeentwentytwo(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 170 + 76;
            myLine.X2 = 205 + 76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1722; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eighteentwentythree(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 170 + 76 + 76;
            myLine.X2 = 205 + 76 + 76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1823; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void nineteentwentyfour(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 170 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1924; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }


        private void twentytwentyfive(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 170 + 76 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76 + 76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 2025; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void seventeenswentyone(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76;
            myLine.X2 = 205;
            myLine.Y1 = 110;
            myLine.Y2 = 66+76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1721; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void eighteentwentytwo(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76+76;
            myLine.X2 = 205+76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1822; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void nineteentwentythree(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 1923; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twentytwentyfour(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 165 + 76 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76;
            myLine.Y1 = 110;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 2024; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twentyonetwentytwo(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205;
            myLine.X2 = 205+76;
            myLine.Y1 = 66+76;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 2122; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twentytwotwentythree(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76;
            myLine.X2 = 205 + 76 + 76;
            myLine.Y1 = 66 + 76;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 2223; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twentythreetwentyfour(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76;
            myLine.Y1 = 66 + 76;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 2324; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }

        private void twentyfourtwentyfive(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 205 + 76 + 76 + 76;
            myLine.X2 = 205 + 76 + 76 + 76 + 76;
            myLine.Y1 = 66 + 76;
            myLine.Y2 = 66 + 76;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            tri[psn] = 2425; psn++;
            if (ctr == 1) ctr++; else ctr--;
            pro();
            tb50.Text = pl1.ToString(); tb51.Text = pl2.ToString();tb55.Text = scor.ToString();
        }
    }

}
