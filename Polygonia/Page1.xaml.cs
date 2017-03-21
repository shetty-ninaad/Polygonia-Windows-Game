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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        static int counter = 2,p1=0,p2=0;
         static int []sqr = new int[50];
         static int pos = 0,score=0,prev=0;

        public Page1()
        {
            InitializeComponent();

        }

        private  void process()
        {
            int i,j,k,x,y,a1,a2,b1,b2,min1,min2,min3,flag1=0,flag2=0;
            int [] array = new int[20] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            if(pos>3)
          for(i=0;i<pos;i++)
            {
                    int[] ar1 = new int[4] { 0, 0, 0, 0 };
                    int[] ar2 = new int[4] { 0, 0, 0, 0 };
                    x = 0; y = 0; a1 = 0; b1 = 0; a2 = 0; b2 = 0;
                    flag1 = 0;flag2 = 0;
                if (sqr[i] < 100)
                {
                    x = sqr[i] % 10;
                    y = sqr[i] / 10;
                }
                else
                {
                    x = sqr[i] % 100;
                    y = sqr[i] / 100;

                }
                if (x - y == 1)
                {
                    a1 = (x + 5);
                    a2 = (x - 5);
                    b1= (y+ 5);
                    b2= (y- 5);
                }
                else
                {
                    a1 = (x + 1);
                    a2 = (x - 1);
                    b1 = (y + 1);
                    b2 = (y - 1);
                }

                    if (a2 <= 25 && a2 >= 0 && b2 >= 25 && b2 <= 0)
                    {
                        ar1[0] = int.Parse(b2.ToString() + y.ToString());
                        ar1[1] = int.Parse(a2.ToString() + x.ToString());
                        ar1[2] = int.Parse(b2.ToString() + a2.ToString());
                        ar1[3] = int.Parse(y.ToString() + x.ToString());
                    }
                    if (a1 <= 25 && a1 >= 0 && b1 >= 0 && b1 <= 25)
                    {
                        ar2[0] = int.Parse(x.ToString() + a1.ToString());
                        ar2[1] = int.Parse(b1.ToString() + a1.ToString());
                        ar2[2] = int.Parse(y.ToString() + b1.ToString());
                        ar2[3] = int.Parse(y.ToString() + x.ToString());
                    }
                if(a2<=25 && a2>=0 && b2>=25 && b2<=0)
                for(j=0;j<4;j++)
                {
                    for(k=0;k<pos;k++)
                    {
                        if (ar1[j] == sqr[k])
                            flag1++;
                    }
                }
                if(flag1==4)
                    {
                        min1 = Math.Min(x, y);
                        min2 = Math.Min(a2,b2);
                        min3 = Math.Min(min1, min2);
                        array[min3] = 1;
                    }

                if(a1<=25 && a1>=0 && b1>=0 && b1<=25)
                for (j = 0; j < 4; j++)
                {
                    for (k = 0; k < pos; k++)
                    {
                        if (ar2[j] == sqr[k])
                            flag2++;
                    }
                }
                if (flag2 == 4)
                    {
                        min1 = Math.Min(x, y);
                        min2 = Math.Min(a1, b1);
                        min3 = Math.Min(min1, min2);
                        array[min3] = 1;
                    }
                    prev = score;
                    score = 0;
                    for (j = 0; j < 20; j++)
                        if (array[j] == 1)
                            score++;

                    if (counter == 1)
                    {
                        //if (score != prev) counter = 2;
                        p1 += (score-prev);
                    }
                    else
                    {
                        //if (score != prev) counter = 1;
                        p2 += (score - prev);
                    }
                }
        }

         public static void main()
        {
            while(true)
            ;
        }
 
        private void onetwo(object sender, MouseButtonEventArgs e)
        {
            
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 195;
            myLine.Y1 = -53;
            myLine.Y2 = -53;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 12; pos++;
            if (counter==1) counter++; else counter--;
            process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();
            ;
        }

        private void sixseven(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 195;
            myLine.Y1 = -15;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 67; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();
            ;
        }

       

        private void eleventwelve(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 195;
            myLine.Y1 = 49;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1112; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        
        private void sixteenseventeen(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 195;
            myLine.Y1 = 110;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1617; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twentyonetwentytwo(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 195;
            myLine.Y1 = 197;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 2122; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

     

        private void twothree(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 272;
            myLine.Y1 = -53;
            myLine.Y2 = -53;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 23; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void threefour(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 348;
            myLine.Y1 = -53;
            myLine.Y2 = -53;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 34; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void fourfive(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 425;
            myLine.Y1 = -53;
            myLine.Y2 = -53;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 45; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void seveneight(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 272;
            myLine.Y1 = -15;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 78; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void eightnine(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 348;
            myLine.Y1 = -15;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 89; pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void nineten(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 425;
            myLine.Y1 = -15;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 910; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twelvethirteen(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 272;
            myLine.Y1 = 49;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1213; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void thirteenfourteen(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 348;
            myLine.Y1 = 49;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1314; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void fourteenfifteen(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 425;
            myLine.Y1 = 49;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1415; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twentytwotwentythree(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 272;
            myLine.Y1 = 197;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 2223; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twentythreetwentyfour(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 348;
            myLine.Y1 = 197;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 2324; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twentyfourtwentyfive(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 425;
            myLine.Y1 = 197;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 2425; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void seventeeneighteen(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 272;
            myLine.Y1 = 110;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1718; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void eighteennineteen(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 348;
            myLine.Y1 = 110;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1819; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void nineteentwenty(object sender, MouseButtonEventArgs e)
        {
            //textBlock.Text = "draw line 0-1";
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 425;
            myLine.Y1 = 110;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1920; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();
        }

        private void onesix(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 118;
            myLine.Y1 = -53;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 16; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();
        }

        private void twoseven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 195;
            myLine.Y1 = -53;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 27;
            pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();
        }

        private void sixeleven(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 118;
            myLine.Y1 = 5;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 611; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();
        }

        private void elevensixteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 118;
            myLine.Y1 = 75;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1116;
            pos++; if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void sixteentwentyone(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 118;
            myLine.X2 = 118;
            myLine.Y1 = 150;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1621; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void seventwelve(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 195;
            myLine.Y1 = 5;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 712; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twelveseventeen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 195;
            myLine.Y1 = 75;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1217; pos++;
            if(counter==1) counter++; else counter--;process();
            tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void seventeentwentytwo(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 195;
            myLine.X2 = 195;
            myLine.Y1 = 150;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1722; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void threeeight(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 272;
            myLine.Y1 = -53;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 38; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void thirteeneighteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 272;
            myLine.Y1 = 75;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1318; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void eightthirteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 272;
            myLine.Y1 = 5;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 813; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void eighteentwentythree(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 272;
            myLine.X2 = 272;
            myLine.Y1 = 150;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1823; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void fournine(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 348;
            myLine.Y1 = -53;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 49; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void ninefourteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 348;
            myLine.Y1 = 5;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 914; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void fourteennineteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 348;
            myLine.Y1 = 75;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1419; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void nineteentwentyfour(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 348;
            myLine.X2 = 348;
            myLine.Y1 = 150;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1924; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void fiveten(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 428;
            myLine.X2 = 428;
            myLine.Y1 = -53;
            myLine.Y2 = -15;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 510; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void tenfifteen(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 428;
            myLine.X2 = 428;
            myLine.Y1 = 5;
            myLine.Y2 = 49;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1015; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void fifteentwenty(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 428;
            myLine.X2 = 428;
            myLine.Y1 = 75;
            myLine.Y2 = 110;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 1520; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }

        private void twentytwentyfive(object sender, MouseButtonEventArgs e)
        {
            Line myLine = new Line();
            myLine.Stroke = Brushes.BlueViolet;
            myLine.X1 = 428;
            myLine.X2 = 428;
            myLine.Y1 = 150;
            myLine.Y2 = 197;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 2;
            mygrid.Children.Add(myLine);
            sqr[pos] = 2025; pos++; if(counter==1) counter++; else counter--;process();tb1.Text = p1.ToString(); tb2.Text = p2.ToString();tb.Text = score.ToString();tb9.Text = prev.ToString();;
        }


        private void button_Click_exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
