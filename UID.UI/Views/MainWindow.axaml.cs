using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Input;
using Avalonia.Media;


namespace UID.UI.Views
{
    public partial class MainWindow : Window
    {
        //private bool isDragging = false;
        //private Point offset;
        Control element;
        private bool isDragging = false;
        private Point offset;

        public MainWindow()
        {
            InitializeComponent();
            //DraggableButton.PointerPressed += OnPointerPressed;
            //DraggableButton.PointerMoved += OnPointerMoved;
            //DraggableButton.PointerReleased += OnPointerReleased;
            //DraggableButton.PointerCaptureLost += OnPointerCaptureLost;

            AddBtn.Click += (_, __) => { AddElement("button"); };
            AddText.Click += (_, __) => { AddElement("text"); };

        }

        private void AddElement(string elementName)
        {
            if (elementName == "button") 
            {
                element = new Button { Content = "I am new added Button", Margin = Thickness.Parse("5") , Background =  Brush.Parse("#9E635C") };
            };

            if (elementName == "text") 
            {
                element = new TextBlock { Text = "I am new added Text", Margin = Thickness.Parse("5"), Foreground = Brush.Parse("#000") };
            };


            element.PointerPressed += OnPointerPressed;  
            element.PointerReleased += OnPointerReleased;   
            element.PointerMoved += OnPointerMoved;
            element.PointerCaptureLost += OnPointerCaptureLost;

            Canvas.SetTop(element, 150);
            Canvas.SetLeft(element, 300);

            MainCanvas.Children.Add(element);            
        }


        private void OnPointerPressed(object sender, PointerPressedEventArgs e)
        {
            if (e.GetCurrentPoint(this).Properties.IsMiddleButtonPressed)
            {
                isDragging = true;
                offset = e.GetPosition(element);
                e.Pointer.Capture(element);
            }
        }

        private void OnPointerMoved(object sender, PointerEventArgs e)
        {
            if (isDragging)
            {
                var position = e.GetPosition(MainCanvas);
                Canvas.SetLeft(element, position.X - offset.X);
                Canvas.SetTop(element, position.Y - offset.Y);

            }
        }

        private void OnPointerReleased(object sender, PointerReleasedEventArgs e)
        {
            isDragging = false;
            e.Pointer.Capture(null);
        }

        private void OnPointerCaptureLost(object sender, PointerCaptureLostEventArgs e)
        {
            // Handle the event if the pointer capture is lost unexpectedly.
            isDragging = false;
        }
    }
}