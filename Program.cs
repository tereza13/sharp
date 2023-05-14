﻿
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

1.Fibonacci series presented with ListBox, TextBox, TextBlock
2.	Text size control, random coloring with RadioButton
3.	Underline Bold Italic with CheckBox
4.	Pencil program, change width and color.
5.	Circle, square and triangle combination
6.	Elipse, rectangular with <combined geometry>
7.	Bezier 
8.	Chess place a knight
9.	Chess place a queen
10.	Chess queen random walk
11.	Chess knight random walk
12.	Random placement of queens
13.	Perform a random knight movement
14.	Creating a menu
15.	Find / replace / next
16.	Copy/cut/past/undo/redo/delete
17.	File input / output
18.	TreeView
19.	Music file creation
20.	Video display with voice control slider 
21.	Button control element animation with C# tags 
22.	Button control element animation with XAML tags
23.	Execute button control element color animation with C#
24.	Color animation of bottom control element with XAML tags
25.	3D triangle 
26.	3D cube
27.	Sorting by age
28.	Searching by name




1.	Fibonacci series presented with ListBox, TextBox, TextBlock
    <Grid>
        <Button Width="100" Height="50" Content="Fibonacci" HorizontalAlignment="Left"
                VerticalAlignment="Bottom" Margin="10, 0, 0, 10" Click="Button_Click">
        </Button>
        <TextBox Name="txtMutq" Width="100" Height="25" HorizontalAlignment="Left"
                 VerticalAlignment="Top"></TextBox>
        <TextBox Name="txtElq" Width="100" Height="200" HorizontalAlignment="Left" />
        <ListBox Name="elqList" Width="100" Height="200" HorizontalAlignment="Right"/>
        <TextBlock Name="elqBlock" Width="100" Height="200" Background="Beige"></TextBlock>

        <Label Width="100" Height="50" Margin="0,-200,0,0" HorizontalAlignment="Left">TextBox</Label>
        <Label Width="100" Height="50" Margin="0,-200,0,0" HorizontalAlignment="Right">ListBox</Label>
        <Label Width="100" Height="50" Margin="0, -200, 0, 0">TextBlock</Label>
    </Grid>
        public MainWindow()
{
    InitializeComponent();
}

private void Button_Click(object sender, RoutedEventArgs e)
{
    txtElq.Text = "";
    elqBlock.Text = "";
    elqList.Items.Clear();

    int a = Convert.ToInt32(txtMutq.Text);
    int n1 = 1, n2 = 1, n3;

    txtElq.Text += Convert.ToString(n1) + "\n";
    elqBlock.Text += Convert.ToString(n1) + "\n";
    elqList.Items.Add(n1);

    txtElq.Text += Convert.ToString(n2) + "\n";
    elqBlock.Text += Convert.ToString(n2) + "\n";
    elqList.Items.Add(n2);
    for (int i = 2; i < a; i++)
    {
        n3 = n1 + n2;
        n1 = n2;
        n2 = n3;

        txtElq.Text += Convert.ToString(n3) + "\n";
        elqBlock.Text += Convert.ToString(n3) + "\n";
        elqList.Items.Add(n3);
    }
}
    }
2.Text size control, random coloring with RadioButton
    <Grid>
        <Label Name="text" Height="200" Width="700">Hello world</Label>
        <Slider Name="sl" VerticalAlignment="Bottom" Width="300" Height="30" Margin="0, 0, 0, 10"
                Background="AliceBlue" Value="10" Maximum="200" ValueChanged="sl_ValueChanged">
        </Slider>
        <RadioButton Name="rb" Click="rb_Click" Margin="10, 0, 0, 10"
                     VerticalAlignment="Bottom">random</RadioButton>
    </Grid>

    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {

        text.FontSize = sl.Value;
        text.Margin = new Thickness(10, 10, 10, 10);
    }

    private void rb_Click(object sender, RoutedEventArgs e)
    {
        Random r = new Random();
        Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
                          (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
        text.Foreground = brush;
    }
}







3.Underline Bold Italic with CheckBox
    <Grid>
        <CheckBox Name="combination" Width="300" Margin="10, 40, 400, 300" Checked="combination_Checked"
                  Unchecked="combination_Unchecked">Bold Italic Underline combination</CheckBox>
        <TextBlock Name="tb" Width="200" Height="400" FontSize="60">hello</TextBlock>
    </Grid>

    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void combination_Checked(object sender, RoutedEventArgs e)
    {
        tb.FontWeight = FontWeights.Bold;
        tb.FontStyle = FontStyles.Italic;
        tb.TextDecorations = TextDecorations.Underline;
    }

    private void combination_Unchecked(object sender, RoutedEventArgs e)
    {
        tb.FontWeight = FontWeights.Normal;
        tb.FontStyle = FontStyles.Normal;
        tb.TextDecorations = null;
    }
}






4.Pencil program, change width and color.
    <Grid x:Name = "grid" >
        < Slider x: Name = "sl" VerticalAlignment = "Bottom" Width = "300" Height = "30" Margin = "0, 0, 0, 10"
                Background = "AliceBlue" Value = "1" Maximum = "50" ></ Slider >
        < RadioButton Name = "black" Width = "50" Margin = "10, 10, 0, 0"
                  HorizontalAlignment = "Left" Click = "black_Click" > black </ RadioButton >
        < RadioButton Name = "red" Width = "50" Margin = "10, 60, 0, 0"
                  HorizontalAlignment = "Left" Click = "red_Click" > red </ RadioButton >
        < RadioButton Name = "green" Width = "50" Margin = "10, 110, 0, 0"
                  HorizontalAlignment = "Left" Click = "green_Click" > green </ RadioButton >
        < RadioButton Name = "blue" Width = "50" Margin = "10, 160, 0, 0"
                  HorizontalAlignment = "Left" Click = "blue_Click" > blue </ RadioButton >

    </ Grid >

    public partial class MainWindow : Window
{
    bool b;
    double x;
    double y;
    bool black1, red1, green1, blue1;

    public MainWindow()
    {
        InitializeComponent();
        MouseDown += MainWindow_MouseDown;
        MouseMove += MainWindow_MouseMove;
        MouseUp += MainWindow_MouseUp;
        black.IsChecked = true;
    }


    private void MainWindow_MouseUp(object sender, MouseButtonEventArgs e)
    {
        b = false;
        Mouse.Capture(null);
    }

    private void MainWindow_MouseMove(object sender, MouseEventArgs e)
    {
        Line a = new Line();
        if (b)
        {
            grid.Children.Add(a);
            a.StrokeThickness = sl.Value;
            a.Stroke = Brushes.Black;
            if (red1)
            {
                a.Stroke = Brushes.Red;
            }
            else if (blue1)
            {
                a.Stroke = Brushes.Blue;
            }
            else if (green1)
            {
                a.Stroke = Brushes.Green;
            }
            else if (black1)
            {
                a.Stroke = Brushes.Black;
            }
            a.X1 = x;
            a.Y1 = y;
            a.X2 = e.GetPosition(this).X;
            a.Y2 = e.GetPosition(this).Y;
        }
        x = a.X2;
        y = a.Y2;
    }

    private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
    {
        b = true;
        x = e.GetPosition(this).X;
        y = e.GetPosition(this).Y;
        Mouse.Capture(this);
    }


    private void blue_Click(object sender, RoutedEventArgs e)
    {
        blue1 = true;
        black1 = false;
        red1 = false;
        green1 = false;
    }

    private void black_Click(object sender, RoutedEventArgs e)
    {
        black1 = true;
        blue1 = false;
        red1 = false;
        green1 = false;
    }

    private void red_Click(object sender, RoutedEventArgs e)
    {
        red1 = true;
        blue1 = false;
        black1 = false;
        green1 = false;
    }

    private void green_Click(object sender, RoutedEventArgs e)
    {
        green1 = true;
        blue1 = false;
        black1 = false;
        red1 = false;
    }
}


















5.Circle, square and triangle combination
    <Grid>
        <Path Name="myPath" Stroke="Black" Fill="Green" MouseDown="Path_MouseDown" 
              MouseMove="Path_MouseMove" MouseUp="Path_MouseUp">
            <Path.Data>
                <GeometryGroup>
                    <RectangleGeometry Rect="0, 0, 150, 150"></RectangleGeometry>
                    <EllipseGeometry Center="150, 150" RadiusX="100" RadiusY="100"></EllipseGeometry>
                    <PathGeometry>
                        <PathFigure IsClosed="True" StartPoint="10, 100">
                            <LineSegment Point="100, 100"/>
                            <LineSegment Point="100, 150"/>
                        </PathFigure>
                    </PathGeometry>
                </GeometryGroup> 
            </Path.Data>
        </Path>
    </Grid>
    public partial class MainWindow : Window
{
    bool b;
    double x, y;

    private void Path_MouseDown(object sender, MouseButtonEventArgs e)
    {
        b = true;
        x = e.GetPosition(this).X - myPath.Margin.Left;
        y = e.GetPosition(this).Y - myPath.Margin.Top;
    }

    private void Path_MouseMove(object sender, MouseEventArgs e)
    {
        if (b)
        {
            myPath.Margin = new Thickness(e.GetPosition(this).X - x, e.GetPosition(this).Y - y,
                0, 0);
        }
    }

    private void Path_MouseUp(object sender, MouseButtonEventArgs e)
    {
        b = false;
    }

    public MainWindow()
    {
        InitializeComponent();
    }

}
6.Elipse, rectangular with<combined geometry>
    <Grid>
        <Path Name = "myPath" Stroke= "Black" Fill= "Blue" MouseDown= "myPath_MouseDown"
              MouseMove= "myPath_MouseMove" MouseUp= "myPath_MouseUp" >
            < Path.Data >
                < CombinedGeometry GeometryCombineMode= "Union" >
                    < CombinedGeometry.Geometry1 >
                        < RectangleGeometry Rect= "0, 0, 150, 150" ></ RectangleGeometry >
                    </ CombinedGeometry.Geometry1 >
                    < CombinedGeometry.Geometry2 >
                        < EllipseGeometry Center= "100, 100" RadiusX= "110" RadiusY= "50" ></ EllipseGeometry >
                    </ CombinedGeometry.Geometry2 >
                </ CombinedGeometry >
            </ Path.Data >
        </ Path >
    </ Grid >

    public partial class MainWindow : Window
{
    bool b;
    double x, y;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void myPath_MouseDown(object sender, MouseButtonEventArgs e)
    {
        b = true;
        x = e.GetPosition(this).X - myPath.Margin.Left;
        y = e.GetPosition(this).Y - myPath.Margin.Top;
    }

    private void myPath_MouseMove(object sender, MouseEventArgs e)
    {
        if (b)
        {
            myPath.Margin = new Thickness(e.GetPosition(this).X - x,
                e.GetPosition(this).Y - y, 0, 0);
        }
    }

    private void myPath_MouseUp(object sender, MouseButtonEventArgs e)
    {
        b = false;
    }
}
7.Bezier
<Grid>
        < Path Stroke = "Red" StrokeThickness = "4" >
            < Path.Data >
                < PathGeometry >
                    < PathFigure StartPoint = "10, 10" >
                        < BezierSegment x: Name = "x2" Point1 = "130, 30" Point2 = "40, 140"
                                       Point3 = "150, 150" ></ BezierSegment >
                    </ PathFigure >
                </ PathGeometry >
            </ Path.Data >
        </ Path >
        < Path Stroke = "Green" StrokeThickness = "3" >
            < Path.Data >
                < GeometryGroup >
                    < LineGeometry x: Name = "l1" StartPoint = "10, 10"
                                  EndPoint = "130, 30" ></ LineGeometry >
                    < LineGeometry x: Name = "l2" StartPoint = "40, 140"
                              EndPoint = "150, 150" ></ LineGeometry >
                </ GeometryGroup >
            </ Path.Data >
        </ Path >
        < Path Stroke = "Blue" StrokeThickness = "13" MouseDown = "Path_MouseDown"  MouseMove = "Path_MouseMove"
              MouseUp = "Path_MouseUp" >
            < Path.Data >
                < GeometryGroup >
                    < EllipseGeometry x: Name = "e1" Center = "130, 30" ></ EllipseGeometry >
                </ GeometryGroup >
            </ Path.Data >
        </ Path >
        < Path Stroke = "Blue" StrokeThickness = "13" MouseDown = "Path_MouseDown_1"  MouseMove = "Path_MouseMove_1"
              MouseUp = "Path_MouseUp_1" >
            < Path.Data >
                < GeometryGroup >
                    < EllipseGeometry x: Name = "e2" Center = "40, 140" ></ EllipseGeometry >
                </ GeometryGroup >
            </ Path.Data >
        </ Path >
    </ Grid >

    public partial class MainWindow : Window
{
    bool b1;
    bool b2;
    public MainWindow()
    {
        InitializeComponent();
    }


    private void Path_MouseDown(object sender, MouseButtonEventArgs e)
    {
        b1 = true;
    }

    private void Path_MouseMove(object sender, MouseEventArgs e)
    {
        if (b1)
        {
            x2.Point1 = new Point(e.GetPosition(this).X, e.GetPosition(this).Y);
            l1.EndPoint = new Point(e.GetPosition(this).X, e.GetPosition(this).Y);
            e1.Center = new Point(e.GetPosition(this).X, e.GetPosition(this).Y);
        }
    }

    private void Path_MouseUp(object sender, MouseButtonEventArgs e)
    {
        b1 = false;
    }

    private void Path_MouseDown_1(object sender, MouseButtonEventArgs e)
    {
        b2 = true;
    }

    private void Path_MouseMove_1(object sender, MouseEventArgs e)
    {
        if (b2)
        {
            x2.Point2 = new Point(e.GetPosition(this).X, e.GetPosition(this).Y);
            l2.StartPoint = new Point(e.GetPosition(this).X, e.GetPosition(this).Y);
            e2.Center = new Point(e.GetPosition(this).X, e.GetPosition(this).Y);
        }
    }

    private void Path_MouseUp_1(object sender, MouseButtonEventArgs e)
    {
        b2 = false;
    }
}





8.Chess place a knight
        Title="MainWindow" Height="438" Width="416" MouseMove="Window_MouseMove">
    <Grid>
        <Image Name="myboard" Source="board.jpg" />
        <Grid Name="ramka"></Grid>
        <Image Name="knight" Source="bn.gif" Margin="0, 0, 0, 0" VerticalAlignment="Top"
               HorizontalAlignment="Left" Width="50" Height="50"
               MouseDown="knight_MouseDown" MouseUp="knight_MouseUp"/>
        
    </Grid>

    public partial class MainWindow : Window
{
    bool b;
    double x, y;
    int h, j;
    bool[,] check = new bool[8, 8];
    public MainWindow()
    {
        InitializeComponent();
    }

    private void knight_MouseDown(object sender, MouseButtonEventArgs e)
    {
        b = true;
        h = (int)knight.Margin.Left;
        j = (int)knight.Margin.Top;
        x = e.GetPosition(this).X - knight.Margin.Left;
        y = e.GetPosition(this).Y - knight.Margin.Top;

        for (int i = -1; i < 2; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = knight.VerticalAlignment;
            im.HorizontalAlignment = knight.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(knight.Margin.Left - 100 * i) / 50 * 50,
                (int)(knight.Margin.Top + 50 * i) / 50 * 50, 0, 0);
            var n = (int)im.Margin.Left / 50;
            var m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
        }
        for (int i = -1; i < 2; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = knight.VerticalAlignment;
            im.HorizontalAlignment = knight.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(knight.Margin.Left + 100 * i) / 50 * 50,
                (int)(knight.Margin.Top + 50 * i) / 50 * 50, 0, 0);
            var n = (int)im.Margin.Left / 50;
            var m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
        }
        for (int i = -1; i < 2; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = knight.VerticalAlignment;
            im.HorizontalAlignment = knight.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(knight.Margin.Left - 50 * i) / 50 * 50,
                (int)(knight.Margin.Top + 100 * i) / 50 * 50, 0, 0);
            var n = (int)im.Margin.Left / 50;
            var m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
        }
        for (int i = -1; i < 2; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = knight.VerticalAlignment;
            im.HorizontalAlignment = knight.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(knight.Margin.Left + 50 * i) / 50 * 50,
                (int)(knight.Margin.Top + 100 * i) / 50 * 50, 0, 0);
            var n = (int)im.Margin.Left / 50;
            var m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
        }

    }

    private void knight_MouseUp(object sender, MouseButtonEventArgs e)
    {
        b = false;
        if (check[(int)(e.GetPosition(this).X) / 50, (int)(e.GetPosition(this).Y) / 50])
        {
            knight.Margin = new Thickness((int)(knight.Margin.Left + 25) / 50 * 50,
                        (int)(knight.Margin.Top + 25) / 50 * 50, 0, 0);
        }
        else
        {
            knight.Margin = new Thickness(h, j, 0, 0);
        }
        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                check[i, j] = false;
            }
        }
        ramka.Children.Clear();
    }

    private void Window_MouseMove(object sender, MouseEventArgs e)
    {
        if (b)
        {
            knight.Margin = new Thickness(e.GetPosition(this).X - x,
                e.GetPosition(this).Y - y, 0, 0);
        }
    }
}


9.Chess place a queen
        Title="MainWindow" Height="438" Width="416" MouseMove="Window_MouseMove">
    <Grid>
        <Image Name="myboard" Source="board.jpg" />
        <Grid Name="ramka"></Grid>
        <Image Name="queen" Source="wq.gif" Margin="0, 0, 0, 0" VerticalAlignment="Top"
               HorizontalAlignment="Left" Width="50" Height="50"
               MouseDown="queen_MouseDown"  MouseUp="queen_MouseUp"/>
    </Grid>

    public partial class MainWindow : Window
{
    bool b;
    double x, y;
    int h, j;
    bool[,] check = new bool[8, 8];
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Window_MouseMove(object sender, MouseEventArgs e)
    {
        if (b)
        {
            queen.Margin = new Thickness(e.GetPosition(this).X - x,
                e.GetPosition(this).Y - y, 0, 0);
        }
    }

    private void queen_MouseDown(object sender, MouseButtonEventArgs e)
    {
        b = true;
        h = (int)queen.Margin.Left;
        j = (int)queen.Margin.Top;
        x = e.GetPosition(this).X - queen.Margin.Left;
        y = e.GetPosition(this).Y - queen.Margin.Top;

        for (int i = -8; i < 8; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = queen.VerticalAlignment;
            im.HorizontalAlignment = queen.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(queen.Margin.Left - 50 * i) / 50 * 50,
                (int)(queen.Margin.Top + 50 * i) / 50 * 50, 0, 0);
            int n = (int)im.Margin.Left / 50;
            int m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = queen.VerticalAlignment;
            im.HorizontalAlignment = queen.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(queen.Margin.Left + 50 * i) / 50 * 50,
                (int)(queen.Margin.Top + 50 * i) / 50 * 50, 0, 0);
            int n = (int)im.Margin.Left / 50;
            int m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = queen.VerticalAlignment;
            im.HorizontalAlignment = queen.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness((int)(queen.Margin.Left - 50 * i) / 50 * 50,
                queen.Margin.Top, 0, 0);
            int n = (int)im.Margin.Left / 50;
            int m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            Image im = new Image();
            im.Width = 50;
            im.Height = 50;
            im.VerticalAlignment = queen.VerticalAlignment;
            im.HorizontalAlignment = queen.HorizontalAlignment;
            im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
            ramka.Children.Add(im);
            im.Margin = new Thickness(queen.Margin.Left,
                (int)(queen.Margin.Top + 50 * i) / 50 * 50, 0, 0);
            int n = (int)im.Margin.Left / 50;
            int m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
    }

    private void queen_MouseUp(object sender, MouseButtonEventArgs e)
    {
        b = false;
        if (check[(int)(e.GetPosition(this).X) / 50, (int)(e.GetPosition(this).Y) / 50])
        {
            queen.Margin = new Thickness((int)(queen.Margin.Left + 25) / 50 * 50,
                (int)(queen.Margin.Top + 25) / 50 * 50, 0, 0);
        }
        else
        {
            queen.Margin = new Thickness(h, j, 0, 0);
        }
        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                check[i, j] = false;
            }
        }
        ramka.Children.Clear();
    }
}










10.Chess queen random walk
    <Grid>
        <Image Name="myboard" Source="board.jpg" />
        <Image Name="queen" Source="wq.gif" Margin="0, 0, 0, 0" VerticalAlignment="Top"
               HorizontalAlignment="Left" Width="50" Height="50"/>
        <Button Name="button" Height="25" Width="25" Margin="65, 15, 0, 0" 
                VerticalAlignment="Top" HorizontalAlignment="Left" Background="DarkRed"
                Click="button_Click"></Button>
    </Grid>

    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        bool[,] check = new bool[8, 8];
        for (int i = -8; i < 8; i++)
        {
            int n = (int)(queen.Margin.Left - 50 * i) / 50;
            int m = (int)(queen.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            int n = (int)(queen.Margin.Left + 50 * i) / 50;
            int m = (int)(queen.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            int n = (int)(queen.Margin.Left - 50 * i) / 50;
            int m = (int)queen.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            int n = (int)queen.Margin.Left / 50;
            int m = (int)(queen.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }

        Random random = new Random();
        int a = random.Next(8);
        int b = random.Next(8);
        while (!check[a, b])
        {
            a = random.Next(8);
            b = random.Next(8);
        }
        queen.Margin = new Thickness(a * 50, b * 50, 0, 0);

        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                check[i, j] = false;
            }
        }
    }
}

11.Chess knight random walk
    <Grid>
        <Image Name="myboard" Source="board.jpg" />
        <Image Name="knight" Source="bn.gif" Margin="0, 0, 0, 0" VerticalAlignment="Top"
               HorizontalAlignment="Left" Width="50" Height="50"/>
        <Button Name="button" Height="25" Width="25" Margin="65, 15, 0, 0" 
                VerticalAlignment="Top" HorizontalAlignment="Left" Background="DarkRed"
                Click="button_Click"></Button>
    </Grid>

        public MainWindow()
{
    InitializeComponent();
}

private void button_Click(object sender, RoutedEventArgs e)
{
    bool[,] check = new bool[8, 8];
    for (int i = -1; i < 2; i++)
    {
        var n = (int)(knight.Margin.Left - 100 * i) / 50;
        var m = (int)(knight.Margin.Top + 50 * i) / 50;
        if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
    }
    for (int i = -1; i < 2; i++)
    {
        var n = (int)(knight.Margin.Left + 100 * i) / 50;
        var m = (int)(knight.Margin.Top + 50 * i) / 50;
        if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
    }
    for (int i = -1; i < 2; i++)
    {
        var n = (int)(knight.Margin.Left - 50 * i) / 50;
        var m = (int)(knight.Margin.Top + 100 * i) / 50;
        if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
    }
    for (int i = -1; i < 2; i++)
    {
        var n = (int)(knight.Margin.Left + 50 * i) / 50;
        var m = (int)(knight.Margin.Top + 100 * i) / 50;
        if (n >= 0 && m >= 0 && n < 8 && m < 8) { check[n, m] = true; }
    }

    Random random = new Random();
    int a = random.Next(8);
    int b = random.Next(8);
    while (!check[a, b])
    {
        a = random.Next(8);
        b = random.Next(8);
    }
    knight.Margin = new Thickness(a * 50, b * 50, 0, 0);

    for (int i = 0; i < 8; ++i)
    {
        for (int j = 0; j < 8; ++j)
        {
            check[i, j] = false;
        }
    }

}
    }
 
12.Random placement of queens
    <Grid>
        <Image Name="myboard" Source="board.jpg" />
        <Button Name="button" Height="25" Width="25" Margin="65, 15, 0, 0" 
                VerticalAlignment="Top" HorizontalAlignment="Left" Background="DarkRed"
                Click="button_Click"></Button>
        <Grid Name="queen"></Grid>
    </Grid>

    public partial class MainWindow : Window
{
    bool[,] check = new bool[8, 8];
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        Image im = new Image();
        im.Width = 50;
        im.Height = 50;
        im.VerticalAlignment = VerticalAlignment.Top;
        im.HorizontalAlignment = HorizontalAlignment.Left;
        im.Source = new BitmapImage(new Uri("wq.gif", UriKind.Relative));
        queen.Children.Add(im);

        Random random = new Random();
        int a = random.Next(8);
        int b = random.Next(8);
        while (check[a, b])
        {
            a = random.Next(8);
            b = random.Next(8);
        }

        im.Margin = new Thickness(a * 50, b * 50, 0, 0);


        for (int i = -8; i < 8; i++)
        {
            int n = (int)(im.Margin.Left - 50 * i) / 50;
            int m = (int)(im.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            int n = (int)(im.Margin.Left + 50 * i) / 50;
            int m = (int)(im.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            int n = (int)(im.Margin.Left - 50 * i) / 50;
            int m = (int)im.Margin.Top / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
        for (int i = -8; i < 8; i++)
        {
            int n = (int)im.Margin.Left / 50;
            int m = (int)(im.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8)
            {
                check[n, m] = true;
            }
        }
    }
}

13.Perform a random knight movement
    <Grid>
        <Image Name="myboard" Source="board.jpg" />
        <Grid Name="ramka"></Grid>
        <Image Name="knight" Source="bn.gif" Margin="0, 0, 0, 0" VerticalAlignment="Top"
               HorizontalAlignment="Left" Width="50" Height="50"/>
        <Button Name="button" Height="25" Width="25" Margin="65, 15, 0, 0" 
                VerticalAlignment="Top" HorizontalAlignment="Left" Background="DarkRed"
                Click="button_Click"></Button>
    </Grid>
    public partial class MainWindow : Window
{
    bool[,] check = new bool[8, 8];
    public MainWindow()
    {
        InitializeComponent();
    }

    private void button_Click(object sender, RoutedEventArgs e)
    {
        bool[,] validMove = new bool[8, 8];
        for (int i = -1; i < 2; i++)
        {
            var n = (int)(knight.Margin.Left - 100 * i) / 50;
            var m = (int)(knight.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { validMove[n, m] = true; }
        }
        for (int i = -1; i < 2; i++)
        {
            var n = (int)(knight.Margin.Left + 100 * i) / 50;
            var m = (int)(knight.Margin.Top + 50 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { validMove[n, m] = true; }
        }
        for (int i = -1; i < 2; i++)
        {
            var n = (int)(knight.Margin.Left - 50 * i) / 50;
            var m = (int)(knight.Margin.Top + 100 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { validMove[n, m] = true; }
        }
        for (int i = -1; i < 2; i++)
        {
            var n = (int)(knight.Margin.Left + 50 * i) / 50;
            var m = (int)(knight.Margin.Top + 100 * i) / 50;
            if (n >= 0 && m >= 0 && n < 8 && m < 8) { validMove[n, m] = true; }
        }

        Random random = new Random();
        int a = random.Next(8);
        int b = random.Next(8);
        while (!validMove[a, b] || check[a, b])
        {
            a = random.Next(8);
            b = random.Next(8);
        }
        knight.Margin = new Thickness(a * 50, b * 50, 0, 0);
        check[a, b] = true;

        for (int i = 0; i < 8; ++i)
        {
            for (int j = 0; j < 8; ++j)
            {
                validMove[i, j] = false;
            }
        }

        Image im = new Image();
        im.Width = 50;
        im.Height = 50;
        im.VerticalAlignment = VerticalAlignment.Top;
        im.HorizontalAlignment = HorizontalAlignment.Left;
        im.Source = new BitmapImage(new Uri("ramka.gif", UriKind.Relative));
        ramka.Children.Add(im);
        im.Margin = new Thickness(knight.Margin.Left, knight.Margin.Top, 0, 0);
    }
}
14.Creating a menu
    <Grid>
        <Menu IsMainMenu = "True" Height= "30" VerticalAlignment= "Top" >
            < MenuItem Header= "new" Click= "MenuItem_Click" ></ MenuItem >
        </ Menu >
        < ListBox Name= "lb" Height= "100" Width= "400" />
    </ Grid >

    public partial class MainWindow : Window
{
    public Window w;
    public TextBox tb;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void MenuItem_Click(object sender, RoutedEventArgs e)
    {
        w = new Window();
        tb = new TextBox();
        tb.Width = 400;
        tb.Height = 100;
        tb.TextWrapping = TextWrapping.Wrap;
        tb.AcceptsReturn = true;
        Button button = new Button();
        button.Width = 150;
        button.Height = 50;
        button.VerticalAlignment = VerticalAlignment.Bottom;
        button.Click += new RoutedEventHandler(Button_Click);
        Grid grid = new Grid();
        grid.Children.Add(tb);
        grid.Children.Add(button);
        w.Content = grid;
        w.ShowDialog();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        lb.Items.Add(tb.Text);
    }
}

15.Find / replace / next
    <Grid>
        < Menu IsMainMenu = "True" Height = "35" VerticalAlignment = "Top" >
            < MenuItem Header = "File" >
                < MenuItem Header = "new" Click = "MenuItem_Click" ></ MenuItem >
            </ MenuItem >
        </ Menu >
        < RichTextBox Name = "mainText" Width = "400" Height = "200"
                 HorizontalScrollBarVisibility = "Visible" />

    </ Grid >

    public partial class MainWindow : Window
{
    public Window w;
    public TextBox tb;
    public TextBox tb1;

    int index;
    int len;
    TextPointer end;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void MenuItem_Click(object sender, RoutedEventArgs e)
    {
        w = new Window();
        w.Height = 450;
        w.Width = 800;

        tb = new TextBox();
        tb.Width = 150;
        tb.Height = 100;
        tb.HorizontalAlignment = HorizontalAlignment.Left;
        tb.TextWrapping = TextWrapping.Wrap;
        tb.AcceptsReturn = true;

        tb1 = new TextBox();
        tb1.Width = 150;
        tb1.Height = 100;
        tb1.TextWrapping = TextWrapping.Wrap;
        tb1.AcceptsReturn = true;

        Button find = new Button();
        find.Content = "Find";
        find.Width = 150;
        find.Height = 50;
        find.VerticalAlignment = VerticalAlignment.Bottom;
        find.HorizontalAlignment = HorizontalAlignment.Left;
        find.Click += new RoutedEventHandler(find_Click);

        Button replace = new Button();
        replace.Content = "Replace";
        replace.Width = 150;
        replace.Height = 50;
        replace.VerticalAlignment = VerticalAlignment.Bottom;
        replace.Click += new RoutedEventHandler(Replace_Click);

        Button next = new Button();
        next.Content = "Next";
        next.Width = 150;
        next.Height = 50;
        next.VerticalAlignment = VerticalAlignment.Bottom;
        next.HorizontalAlignment = HorizontalAlignment.Right;
        next.Click += new RoutedEventHandler(Next_Click);

        Grid grid = new Grid();
        grid.Children.Add(tb);
        grid.Children.Add(tb1);
        grid.Children.Add(find);
        grid.Children.Add(replace);
        grid.Children.Add(next);
        w.Content = grid;
        w.ShowDialog();
    }

    private void Next_Click(object sender, RoutedEventArgs e)
    {
        mainText.Selection.ClearAllProperties();
        TextRange textRange = new TextRange(end, mainText.Document.ContentEnd);
        index = textRange.Text.IndexOf(tb.Text);
        len = tb.Text.Length;
        if (index >= 0)
        {
            TextPointer start = textRange.Start.GetPositionAtOffset(index, LogicalDirection.Forward);
            end = textRange.Start.GetPositionAtOffset(index + len, LogicalDirection.Backward);
            mainText.Selection.Select(start, end);
            mainText.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Yellow));
        }
    }

    private void Replace_Click(object sender, RoutedEventArgs e)
    {
        mainText.Selection.Text = tb1.Text;
    }

    private void find_Click(object sender, RoutedEventArgs e)
    {
        mainText.Selection.ClearAllProperties();
        TextRange textRange = new TextRange(mainText.Document.ContentStart, mainText.Document.ContentEnd);
        index = textRange.Text.IndexOf(tb.Text);
        len = tb.Text.Length;
        if (index >= 0)
        {
            TextPointer start = textRange.Start.GetPositionAtOffset(index, LogicalDirection.Forward);
            end = textRange.Start.GetPositionAtOffset(index + len, LogicalDirection.Backward);
            mainText.Selection.Select(start, end);
            mainText.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, new SolidColorBrush(Colors.Yellow));
        }
    }
}
16.Copy / cut / past / undo / redo / delete
<Grid>
        < ToolBar Background = "AliceBlue" >
            < Button Name = "copy" Content = "copy" Height = "40" Width = "40" Click = "copy_Click" ></ Button >
            < Button Name = "cut" Content = "cut" Height = "40" Width = "40" Click = "cut_Click" ></ Button >
            < Button Name = "paste" Content = "paste" Height = "40" Width = "40" Click = "paste_Click" ></ Button >
            < Button Name = "undo" Content = "undo" Height = "40" Width = "40" Click = "undo_Click" ></ Button >
            < Button Name = "redo" Content = "redo" Height = "40" Width = "40" Click = "redo_Click" ></ Button >
            < Button Name = "delete" Content = "delete" Height = "40" Width = "45" Click = "delete_Click" ></ Button >
        </ ToolBar >
        < TextBox Name = "t" Width = "150" Height = "150" TextWrapping = "Wrap" AcceptsReturn = "true"
                 Background = "Beige" ScrollViewer.VerticalScrollBarVisibility = "Visible" ></ TextBox >
    </ Grid >

    public partial class MainWindow : Window
{
    string s;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void copy_Click(object sender, RoutedEventArgs e)
    {
        s = t.SelectedText;
        copy.Background = new SolidColorBrush(Colors.Bisque);
    }

    private void cut_Click(object sender, RoutedEventArgs e)
    {
        s = t.SelectedText;
        t.SelectedText = "";
        cut.Background = new SolidColorBrush(Colors.Bisque);
    }

    private void paste_Click(object sender, RoutedEventArgs e)
    {
        t.SelectedText = s;
        copy.Background = new SolidColorBrush(Colors.AliceBlue);
        cut.Background = new SolidColorBrush(Colors.AliceBlue);
    }

    private void undo_Click(object sender, RoutedEventArgs e)
    {
        t.Undo();
    }

    private void redo_Click(object sender, RoutedEventArgs e)
    {
        t.Redo();
    }

    private void delete_Click(object sender, RoutedEventArgs e)
    {
        t.SelectedText = "";
    }
}
17.File input / output
<Grid>
        < Menu IsMainMenu = "True" Height = "26" VerticalAlignment = "Top" >
            < MenuItem Name = "write" Header = "Write" Click = "write_Click" />
            < MenuItem Name = "read" Header = "Read" Click = "read_Click" />
        </ Menu >
        < Label Content = "File Name" Margin = "90, 140, 0, 0" ></ Label >
        < TextBox Name = "fn" Height = "30" Width = "250" HorizontalAlignment = "Left"
                 TextWrapping = "Wrap" Background = "Bisque" />
        < Label Content = "Text Input and Write File" Margin = "320, 140, 0, 0" />
        < TextBox Name = "textbox" Height = "60" Width = "250" TextWrapping = "Wrap"
                 AcceptsReturn = "True" Background = "AliceBlue" />
        < Label Content = "Text Read From File" Margin = "600, 140, 0, 0" />
        < TextBlock Name = "textblock" Height = "60" Width = "250" Background = "AliceBlue"
                   HorizontalAlignment = "Right" TextWrapping = "Wrap" />
    </ Grid >
    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void write_Click(object sender, RoutedEventArgs e)
    {
        File.WriteAllText(fn.Text, textbox.Text);
    }

    private void read_Click(object sender, RoutedEventArgs e)
    {
        textblock.Text = File.ReadAllText(fn.Text);
    }
}

18.TreeView
<Grid>
        < Grid.ColumnDefinitions >
            < ColumnDefinition ></ ColumnDefinition >
            < ColumnDefinition ></ ColumnDefinition >
        </ Grid.ColumnDefinitions >
        < TreeView Name = "DirectoryTreeView" Grid.Column = "0"
                  TreeViewItem.Expanded = "DirectoryTreeView_Expanded"
                  TreeViewItem.Selected = "DirectoryTreeView_Selected" ></ TreeView >
        < TreeView  Name = "FilesTreeView" Grid.Column = "1"
                   TreeViewItem.Selected = "FilesTreeView_Selected" ></ TreeView >
    </ Grid >

using System.IO;
    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
            TreeViewItem item = new TreeViewItem();
            item.Tag = drive;
            item.Header = drive.ToString();
            item.Items.Add("*");
            DirectoryTreeView.Items.Add(item);
        }
    }

    private void DirectoryTreeView_Expanded(object sender, RoutedEventArgs e)
    {
        TreeViewItem item = (TreeViewItem)e.OriginalSource;
        item.Items.Clear();
        DirectoryInfo dir;
        if (item.Tag is DriveInfo)
        {
            DriveInfo drive = (DriveInfo)item.Tag;
            dir = drive.RootDirectory;
        }
        else
        {
            dir = (DirectoryInfo)item.Tag;
        }
        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Tag = d;
            newItem.Header = d.ToString();
            newItem.Items.Add("*");
            item.Items.Add(newItem);
        }
    }

    private void DirectoryTreeView_Selected(object sender, RoutedEventArgs e)
    {
        TreeViewItem item = (TreeViewItem)e.OriginalSource;
        DirectoryInfo dir;
        FilesTreeView.Items.Clear();
        if (item.Tag is DriveInfo)
        {
            DriveInfo drive = (DriveInfo)item.Tag;
            dir = drive.RootDirectory;
        }
        else
        {
            dir = (DirectoryInfo)item.Tag;
        }
        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Tag = d;
            newItem.Header = d.ToString();
            FilesTreeView.Items.Add(newItem);
        }
        foreach (FileInfo file in dir.GetFiles())
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Tag = file;
            newItem.Header = file.ToString();
            FilesTreeView.Items.Add(newItem);
        }
    }

    private void FilesTreeView_Selected(object sender, RoutedEventArgs e)
    {
        TreeViewItem item = (TreeViewItem)e.OriginalSource;
        DirectoryInfo dir;
        FilesTreeView.Items.Clear();
        if (item.Tag is DriveInfo)
        {
            DriveInfo drive = (DriveInfo)item.Tag;
            dir = drive.RootDirectory;
        }
        else
        {
            dir = (DirectoryInfo)item.Tag;
        }
        foreach (DirectoryInfo d in dir.GetDirectories())
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Tag = d;
            newItem.Header = d.ToString();
            FilesTreeView.Items.Add(newItem);
        }
        foreach (FileInfo file in dir.GetFiles())
        {
            TreeViewItem newItem = new TreeViewItem();
            newItem.Tag = file;
            newItem.Header = file.ToString();
            FilesTreeView.Items.Add(newItem);
        }
    }
}




















19.Music file creation
    <Grid>
        <Button Name = "play" Click= "play_Click" Height= "30" Width= "80" HorizontalAlignment= "Left"
                VerticalAlignment= "Bottom" > play </ Button >
        < Button Name= "stop" Click= "Stop_Click" Height= "30" Width= "80" HorizontalAlignment= "Right"
                VerticalAlignment= "Bottom" > stop </ Button >
        < Button Name= "pause" Click= "pause_Click" Height= "30" Width= "80"
                VerticalAlignment= "Bottom" > pause </ Button >
        < Slider Name= "seek" Height= "30" ValueChanged= "seek_ValueChanged" Value= "0"
                Minimum= "0" Maximum= "100" ></ Slider >
        < Slider Name= "vol" Height= "30" ValueChanged= "vol_ValueChanged" VerticalAlignment= "Top"
                Minimum= "0" Value= "0.5" Maximum= "1" ></ Slider >
    </ Grid >

    public partial class MainWindow : Window
{
    MediaPlayer mp = new MediaPlayer();
    DispatcherTimer timer = new DispatcherTimer();
    public MainWindow()
    {
        InitializeComponent();
        mp.Open(new Uri("C:\\Users\\DELL\\Coding\\C#\\Problems\\19\\19 (new)\\Sd.mp3", UriKind.Relative));
        timer.Interval = TimeSpan.FromMilliseconds(1);
        timer.Tick += Timer_Tick;
        timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        seek.Value = mp.Position.TotalMilliseconds;

    }

    private void play_Click(object sender, RoutedEventArgs e)
    {
        mp.Play();
        seek.Value = mp.Position.TotalMilliseconds;
    }

    private void Stop_Click(object sender, RoutedEventArgs e)
    {
        mp.Stop();
        seek.Value = 0;
    }

    private void pause_Click(object sender, RoutedEventArgs e)
    {
        mp.Pause();
    }

    private void seek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        seek.Maximum = mp.NaturalDuration.TimeSpan.TotalMilliseconds;
        mp.Position = TimeSpan.FromMilliseconds(seek.Value);
        seek.Value = mp.Position.TotalMilliseconds;
    }

    private void vol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        mp.Volume = vol.Value;
    }
}
20.Video display with voice control slider 
    <Grid>
        <MediaElement Name="me" Source="C:\Users\DELL\Coding\C#\Problems\20\20\Harry styles consequences.mp4" 
                      Width="600" LoadedBehavior="Manual" MediaOpened="me_MediaOpened"/>
        <Button Name="play" Height="30" Width="60" Click="Play_Click"
                HorizontalAlignment="Left">play</Button>
        <Button Name="stop" Click="stop_Click" Height="30" Width="60" 
                HorizontalAlignment="Left" Margin="0,266,0,126.8">stop</Button>
        <Button Name="pause" Click="pause_Click" Height="30" Width="60"
                HorizontalAlignment="Left" Margin="0,230,0,160">pause</Button>
        <Slider Name="seek" Height="20" Maximum="50" Minimum="0" Value="0"
                VerticalAlignment="Bottom" ValueChanged="seek_ValueChanged"/>
        <Slider Name="vol" Height="30" ValueChanged="vol_ValueChanged" VerticalAlignment="Top"
                Minimum="0" Value="0.5" Maximum="1"></Slider>
    </Grid>

    public partial class MainWindow : Window
{
    DispatcherTimer timer;
    public MainWindow()
    {
        InitializeComponent();
        timer = new DispatcherTimer();
        timer.Tick += Timer_Tick;
        timer.Interval = TimeSpan.FromMilliseconds(10);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        seek.Value = me.Position.TotalMilliseconds;
    }

    private void Play_Click(object sender, RoutedEventArgs e)
    {
        me.Play();
        seek.Value = me.Position.TotalMilliseconds;
    }

    private void seek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        me.Position = TimeSpan.FromMilliseconds(seek.Value);
        seek.Value = me.Position.TotalMilliseconds;
    }

    private void me_MediaOpened(object sender, RoutedEventArgs e)
    {
        seek.Maximum = me.NaturalDuration.TimeSpan.TotalMilliseconds;
        timer.Start();
    }

    private void stop_Click(object sender, RoutedEventArgs e)
    {
        me.Stop();
        seek.Value = 0;
    }

    private void pause_Click(object sender, RoutedEventArgs e)
    {
        me.Pause();
    }

    private void vol_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        me.Volume = vol.Value;
    }
}

21.Button control element animation with C# tags 
    <Grid>
        <Button Name="b" Width="100" Height="100" Click="b_Click"></Button>
        <Button Click="Button_Click" Margin="0, 0, 440, 260" Width="100" Height="60">start</Button>
    </Grid>

    public partial class MainWindow : Window
{
    DoubleAnimation a;

    private void b_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("hello");
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        a = new DoubleAnimation();
        a.From = 50;
        a.To = 300;
        a.Duration = TimeSpan.FromSeconds(10);
        a.RepeatBehavior = RepeatBehavior.Forever;
        b.BeginAnimation(Button.WidthProperty, a);
    }

    public MainWindow()
    {
        InitializeComponent();
    }
}

22.Button control element animation with XAML tags
    <Grid>
        <Button Name="b" Height="40" Width="160" Click="b_Click">
            <Button.Triggers>
                <EventTrigger RoutedEvent="Button.Click">
                    <EventTrigger.Actions>
                        <BeginStoryboard>
                            <Storyboard>
                                <DoubleAnimation Storyboard.TargetProperty="Width"
                                                 To="300" 
                                                 Duration="0:0:5" 
                                                 RepeatBehavior="Forever"></DoubleAnimation>
                            </Storyboard>
                        </BeginStoryboard>
                    </EventTrigger.Actions>
                </EventTrigger>
            </Button.Triggers>
        </Button>
    </Grid>

    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void b_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hi");
    }
}

23.Execute button control element color animation with C#
    <Grid>
        <Button Name="b" Width="100" Height="100" Click="b_Click"></Button>
        <Button Click="Button_Click" Margin="0, 0, 440, 260" Width="100" Height="60">start</Button>
    </Grid>

    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

        SolidColorBrush brush = new SolidColorBrush(Colors.Red);
        b.Background = brush;

        ColorAnimation a = new ColorAnimation(Colors.Red, Colors.Blue, new Duration(TimeSpan.FromSeconds(2)));

        a.AutoReverse = true;
        a.RepeatBehavior = RepeatBehavior.Forever;
        brush.BeginAnimation(SolidColorBrush.ColorProperty, a);

    }

    private void b_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hi");
    }
}

24.Color animation of bottom control element with XAML tags
    <Grid>
        <Button Height="75" Name="b" Width="160" Background="Red" Click="b_Click">
            <Button.Triggers>
                <EventTrigger RoutedEvent="Button.Click">
                    <BeginStoryboard>
                        <Storyboard>
                            <ColorAnimation To="Blue" 
                                    Storyboard.TargetProperty="(Button.Background).(SolidColorBrush.Color)" 
                                    RepeatBehavior="Forever"
                                    AutoReverse="True" 
                                    Duration="0:0:2"/>
                        </Storyboard>
                    </BeginStoryboard>
                </EventTrigger>
            </Button.Triggers>
        </Button>
    </Grid>

    public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void b_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("hi");
    }
}

25. 3D triangle
    <Grid>
        < Viewport3D >
            < Viewport3D.Camera >
                < PerspectiveCamera Position = "-2, 2, 2" LookDirection = "2, -2, -2" UpDirection = "0, 1, 0" />
            </ Viewport3D.Camera >
            < ModelVisual3D >
                < ModelVisual3D.Content >
                    < DirectionalLight Color = "White" Direction = "0, 0, -1" />
                </ ModelVisual3D.Content >
            </ ModelVisual3D >
            < ModelVisual3D >
                < ModelVisual3D.Content >
                    < GeometryModel3D >
                        < GeometryModel3D.Geometry >
                            < MeshGeometry3D Positions = "-1, 0, 0, 0, 1, 0, 1, 0, 0"
                                            TriangleIndices = "0, 2, 1"
                                            TextureCoordinates = "1,1 0,1 1,0 0,0 0,1 1,1 0,0 1,0" />
                        </ GeometryModel3D.Geometry >
                        < GeometryModel3D.Material >
                            < DiffuseMaterial >
                                < DiffuseMaterial.Brush >
                                    < ImageBrush ImageSource = "pic.jpg" />
                                </ DiffuseMaterial.Brush >
                            </ DiffuseMaterial >
                        </ GeometryModel3D.Material >
                    </ GeometryModel3D >
                </ ModelVisual3D.Content >
                < ModelVisual3D.Transform >
                    < RotateTransform3D >
                        < RotateTransform3D.Rotation >
                            < AxisAngleRotation3D x: Name = "rotate" Axis = "0 1 0" Angle = "12" />
                        </ RotateTransform3D.Rotation >
                    </ RotateTransform3D >
                </ ModelVisual3D.Transform >
            </ ModelVisual3D >
            < Viewport3D.Triggers >
                < EventTrigger RoutedEvent = "Viewport3D.Loaded" >
                    < BeginStoryboard >
                        < Storyboard >
                            < DoubleAnimation Storyboard.TargetName = "rotate"
                                             Storyboard.TargetProperty = "Angle"
                                             From = "0" To = "360" Duration = "0:0:4"
                                             RepeatBehavior = "Forever" />
                        </ Storyboard >
                    </ BeginStoryboard >
                </ EventTrigger >
            </ Viewport3D.Triggers >
        </ Viewport3D >
    </ Grid >
26. 3D cube
    <Grid>
        < Viewport3D >
            < Viewport3D.Camera >
                < PerspectiveCamera Position = "-40,40,40" LookDirection = "40,-40,-40" UpDirection = "0,0,1" />
            </ Viewport3D.Camera >
            < ModelVisual3D >
                < ModelVisual3D.Content >
                    < Model3DGroup >
                        < DirectionalLight Color = "White" Direction = "-1, -1, -3" />
                        < GeometryModel3D >
                        < GeometryModel3D.Geometry >
                                < MeshGeometry3D Positions = "0,0,0 10,0,0 0,10,0 10,10,0
                                                           0,0,0 0,0,10 0,10,0 0,10,10
                                                           0,0,0 10,0,0 0,0,10 10,0,10
                                                           10,0,0 10,10,10 10,0,10 10,10,0
                                                           0,0,10 10,0,10 0,10,10 10,10,10
                                                           0,10,0 0,10,10 10,10,0 10,10,10"
                                            TriangleIndices = "0,2,1 1,2,3
                                                             4,5,6 6,5,7
                                                             8,9,10 9,11,10
                                                             12,13,14 12,15,13
                                                             16,17,18 19,18,17
                                                             20,21,22 22,21,23"
                                                TextureCoordinates = "0,0 0,1 1,0 1,1
                                                                    1,1 0,1 1,0 0,0
                                                                    0,0 1,0 0,1 1,1
                                                                    0,0 1,0 0,1 1,1
                                                                    1,1 0,1 1,0 0,0
                                                                    1,1 0,1 1,0 0,0"/>
                            </ GeometryModel3D.Geometry >
                            < GeometryModel3D.Material >
                                < MaterialGroup >
                                    < DiffuseMaterial >
                                        < DiffuseMaterial.Brush >
                                            < ImageBrush ImageSource = "pic.jpg" />
                                        </ DiffuseMaterial.Brush >
                                    </ DiffuseMaterial >
                                </ MaterialGroup >
                            </ GeometryModel3D.Material >
                            < GeometryModel3D.Transform >
                                < TranslateTransform3D x: Name = "myTranslateTransform3D"
                                                  OffsetX = "0" OffsetY = "0" OffsetZ = "0" />
                            </ GeometryModel3D.Transform >
                        </ GeometryModel3D >
                    </ Model3DGroup >
                </ ModelVisual3D.Content >
                < ModelVisual3D.Transform >
                    < RotateTransform3D >
                        < RotateTransform3D.Rotation >
                            < AxisAngleRotation3D x: Name = "myAngleRotation" Axis = "0 0 1" Angle = "12" />
                        </ RotateTransform3D.Rotation >
                    </ RotateTransform3D >
                </ ModelVisual3D.Transform >
            </ ModelVisual3D >
        </ Viewport3D >
        < Slider Name = "sl" Height = "30" Width = "190" Maximum = "0" Minimum = "-360"
                VerticalAlignment = "Bottom" Value = "{Binding ElementName=myAngleRotation, Path=Angle}" ></ Slider >
    </ Grid >
27.Sorting by age
    <Grid>
        <TextBox Name = "name" Width= "100" Height= "50" Margin= "10,111,685.2,261.8" />
        < Label Width= "70" Height= "30" Margin= "26,81,699.2,310" > Name </ Label >
        < TextBox Name= "age" Width= "100" Height= "50" Margin= "115,111,580.2,261.8" />
        < Label Width= "70" Height= "30" Margin= "130,82,595.2,310.8" > Age </ Label >
        < Button Width= "80" Height= "40" Content= "Enter" Margin= "80,178,635.2,204.8"
                Name= "input" Click= "input_Click" ></ Button >

        < ListBox Name= "display" Width= "200" Height= "100" Margin= "235,111,360.2,211.8" />
        < Label Width= "70" Height= "30" Margin= "269,76,456.2,316.8" > Display </ Label >

        < ListBox Name= "sort" Width= "200" Height= "100" Margin= "461,111,134.2,211.8" />
        < Label Width= "120" Height= "30" Margin= "481,76,194.2,316.8" > Sort by age</Label>
        <Button Width = "80" Height= "40" Content= "Sort" Margin= "521,216,194.2,166.8"
                Name= "Sort" Click= "Sort_Click" ></ Button >

        < TextBox Name= "delete" Width= "100" Height= "50" Margin= "685,111,10.2,261.8" />
        < Label Width= "120" Height= "30" Margin= "685,76,-9.8,316.8" > Name delete</Label>
        <Button Width = "80" Height= "40" Content= "Delete" Margin= "699,166,16.2,216.8"
                Name= "Delete" Click= "delete_Click" ></ Button >

    </ Grid >
    public partial class MainWindow : Window
{
    Person[] list = new Person[50];
    int k = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void input_Click(object sender, RoutedEventArgs e)
    {
        Person person = new Person();
        person.name = Convert.ToString(name.Text);
        person.age = Convert.ToInt32(age.Text);
        list[k] = person;
        k++;
        name.Text = "";
        age.Text = "";
        display.Items.Add(person.name + ",  " + person.age);
    }

    private void Sort_Click(object sender, RoutedEventArgs e)
    {
        sort.Items.Clear();
        Person p = new Person();
        for (int z = 0; z < k; z++)
        {
            for (int i = 0; i < k - 1; i++)
            {
                if (list[i].age > list[i + 1].age)
                {
                    p = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = p;
                }
            }
        }

        for (int i = 0; i < k; i++)
        {
            sort.Items.Add(list[i].name + ",  " + list[i].age);
        }

    }

    private void delete_Click(object sender, RoutedEventArgs e)
    {
        string name = Convert.ToString(delete.Text);
        int i;
        for (i = 0; i < k; i++)
        {
            if (list[i].name == name)
            {
                display.Items.Remove(display.Items.GetItemAt(i));
                k--;
                for (int z = i; z < k; z++)
                {
                    list[z] = list[z + 1];
                }
                break;
            }
        }

        delete.Text = "";
    }
}

class Person
{
    public string name { get; set; }
    public int age { get; set; }
}





28.Searching by name
    <Grid>
        <TextBox Name = "name" Width= "100" Height= "50" Margin= "10,111,685.2,261.8" />
        < Label Width= "70" Height= "30" Margin= "26,81,699.2,310" > Name </ Label >
        < TextBox Name= "age" Width= "100" Height= "50" Margin= "115,111,580.2,261.8" />
        < Label Width= "70" Height= "30" Margin= "130,82,595.2,310.8" > Age </ Label >
        < Button Width= "80" Height= "40" Content= "Enter" Margin= "80,178,635.2,204.8"
                Name= "input" Click= "input_Click" ></ Button >

        < ListBox Name= "display" Width= "200" Height= "100" Margin= "235,111,360.2,211.8" />
        < Label Width= "70" Height= "30" Margin= "269,76,456.2,316.8" > Display </ Label >

        < TextBox Name= "search" Width= "100" Height= "50" Margin= "430,111,234.2,261.8" />
        < Label Width= "120" Height= "30" Margin= "446,76,229.2,316.8" > Search by name</Label>
        <Button Width = "80" Height= "40" Content= "Search" Margin= "446,166,269.2,216.8"
                Name= "Search" Click= "Search_Click" ></ Button >
        < ListBox Name= "searchResult" Width= "130" Height= "50" Margin= "550,111,115.2,261.8" />

        < TextBox Name= "delete" Width= "100" Height= "50" Margin= "685,111,10.2,261.8" />
        < Label Width= "120" Height= "30" Margin= "685,76,-9.8,316.8" > Name delete</Label>
        <Button Width = "80" Height= "40" Content= "Delete" Margin= "699,166,16.2,216.8"
                Name= "Delete" Click= "Delete_Click" ></ Button >
    </ Grid >

    public partial class MainWindow : Window
{
    Person[] list = new Person[50];
    int k = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void input_Click(object sender, RoutedEventArgs e)
    {
        Person person = new Person();
        person.name = Convert.ToString(name.Text);
        person.age = Convert.ToInt32(age.Text);
        list[k] = person;
        k++;
        name.Text = "";
        age.Text = "";
        display.Items.Add(person.name + ",  " + person.age);
    }

    private void Search_Click(object sender, RoutedEventArgs e)
    {
        searchResult.Items.Clear();
        string searchName = Convert.ToString(search.Text);
        for (int i = 0; i < k; i++)
        {
            if (searchName == list[i].name)
            {
                searchResult.Items.Add(list[i].name + ",  " + list[i].age);
                break;
            }

        }

    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {
        string name = Convert.ToString(delete.Text);
        int i;
        for (i = 0; i < k; i++)
        {
            if (list[i].name == name)
            {
                display.Items.Remove(display.Items.GetItemAt(i));
                k--;
                for (int z = i; z < k; z++)
                {
                    list[z] = list[z + 1];
                }
                break;
            }
        }

        delete.Text = "";
    }
}


class Person
{
    public string name { get; set; }
    public int age { get; set; }
}



