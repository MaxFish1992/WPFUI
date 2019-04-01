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

namespace ZdfFlatUI
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:ZdfFlatUI.MyControls.TabControl.Implementation"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中: 
    ///
    ///     xmlns:MyNamespace="clr-namespace:ZdfFlatUI.MyControls.TabControl.Implementation;assembly=ZdfFlatUI.MyControls.TabControl.Implementation"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误: 
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:CloseTabControl/>
    ///
    /// </summary>
    public class CloseTabControl : TabItem
    {
        static CloseTabControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseTabControl), new FrameworkPropertyMetadata(typeof(CloseTabControl)));
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(e.Property, e.NewValue);
        }

        /// <summary>
        /// 是否可以关闭
        /// </summary>
        public bool IsCanClose
        {
            get { return (bool)GetValue(IsCanCloseProperty); }
            set { SetValue(IsCanCloseProperty, value); }
        }

        public static readonly DependencyProperty IsCanCloseProperty =
            DependencyProperty.Register("IsCanClose", typeof(bool), typeof(CloseTabControl), new PropertyMetadata(true, OnPropertyChanged));

        /// <summary>
        /// 关闭的图标
        /// </summary>
        public ImageSource CloseIcon
        {
            get { return (ImageSource)GetValue(CloseIconProperty); }
            set { SetValue(CloseIconProperty, value); }
        }

        public static readonly DependencyProperty CloseIconProperty =
            DependencyProperty.Register("CloseIcon", typeof(ImageSource), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));



        /// <summary>
        /// 正常背景色
        /// </summary>
        public SolidColorBrush NormalBackground
        {
            get { return (SolidColorBrush)GetValue(NormalBackgroundProperty); }
            set { SetValue(NormalBackgroundProperty, value); }
        }

        public static readonly DependencyProperty NormalBackgroundProperty =
            DependencyProperty.Register("NormalBackground", typeof(SolidColorBrush), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 悬浮背景色
        /// </summary>
        public SolidColorBrush OverBackgound
        {
            get { return (SolidColorBrush)GetValue(OverBackgoundProperty); }
            set { SetValue(OverBackgoundProperty, value); }
        }

        public static readonly DependencyProperty OverBackgoundProperty =
            DependencyProperty.Register("OverBackgound", typeof(SolidColorBrush), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 选中背景色
        /// </summary>
        public SolidColorBrush SelectedBackgound
        {
            get { return (SolidColorBrush)GetValue(SelectedBackgoundProperty); }
            set { SetValue(SelectedBackgoundProperty, value); }
        }

        public static readonly DependencyProperty SelectedBackgoundProperty =
            DependencyProperty.Register("SelectedBackgound", typeof(SolidColorBrush), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 默认前景色
        /// </summary>
        public SolidColorBrush NormalForeground
        {
            get { return (SolidColorBrush)GetValue(NormalForegroundProperty); }
            set { SetValue(NormalForegroundProperty, value); }
        }

        public static readonly DependencyProperty NormalForegroundProperty =
            DependencyProperty.Register("NormalForeground", typeof(SolidColorBrush), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 悬浮前景色
        /// </summary>
        public SolidColorBrush OverForeground
        {
            get { return (SolidColorBrush)GetValue(OverForegroundProperty); }
            set { SetValue(OverForegroundProperty, value); }
        }

        public static readonly DependencyProperty OverForegroundProperty =
            DependencyProperty.Register("OverForeground", typeof(SolidColorBrush), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 选中前景色
        /// </summary>
        public SolidColorBrush SelectedForeground
        {
            get { return (SolidColorBrush)GetValue(SelectedForegroundProperty); }
            set { SetValue(SelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof(SolidColorBrush), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 控件圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CloseTabControl), new PropertyMetadata(new CornerRadius(0), OnPropertyChanged));


        /// <summary>
        /// 前置Logo
        /// </summary>
        public ImageSource LogoIcon
        {
            get { return (ImageSource)GetValue(LogoIconProperty); }
            set { SetValue(LogoIconProperty, value); }
        }

        public static readonly DependencyProperty LogoIconProperty =
            DependencyProperty.Register("LogoIcon", typeof(ImageSource), typeof(CloseTabControl), new PropertyMetadata(null, OnPropertyChanged));



        /// <summary>
        /// 前置Logo宽度
        /// </summary>
        public double LogoIconWidth
        {
            get { return (double)GetValue(LogoIconWidthProperty); }
            set { SetValue(LogoIconWidthProperty, value); }
        }

        public static readonly DependencyProperty LogoIconWidthProperty =
            DependencyProperty.Register("LogoIconWidth", typeof(double), typeof(CloseTabControl), new PropertyMetadata(double.Parse("0"), OnPropertyChanged));


        /// <summary>
        /// 前置Logo高度
        /// </summary>
        public double LogoIconHeigth
        {
            get { return (double)GetValue(LogoIconHeigthProperty); }
            set { SetValue(LogoIconHeigthProperty, value); }
        }

        public static readonly DependencyProperty LogoIconHeigthProperty =
            DependencyProperty.Register("LogoIconHeigth", typeof(double), typeof(CloseTabControl), new PropertyMetadata(double.Parse("0"), OnPropertyChanged));


        /// <summary>
        /// LogoPadding
        /// </summary>
        public Thickness LogoPadding
        {
            get { return (Thickness)GetValue(LogoPaddingProperty); }
            set { SetValue(LogoPaddingProperty, value); }
        }

        public static readonly DependencyProperty LogoPaddingProperty =
            DependencyProperty.Register("LogoPadding", typeof(Thickness), typeof(CloseTabControl), new PropertyMetadata(new Thickness(0), OnPropertyChanged));

        /// <summary>
        /// 关闭item事件
        /// </summary>
        public event RoutedEventHandler CloseItem
        {
            add { AddHandler(CloseItemEvent, value); }
            remove { RemoveHandler(CloseItemEvent, value); }
        }
        public static readonly RoutedEvent CloseItemEvent =
            EventManager.RegisterRoutedEvent("CloseItem", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CloseTabControl));

        /// <summary>
        /// 关闭项的右键菜单
        /// </summary>
        public ContextMenu ItemContextMenu { get; set; }

        Border ItemBorder;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            ItemBorder = Template.FindName("_bordertop", this) as Border;
            if (ItemContextMenu != null)
            {
                ItemBorder.ContextMenu = ItemContextMenu;
            }
        }
    }
}
