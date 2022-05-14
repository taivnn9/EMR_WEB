using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EMR_MAIN
{
    /// <summary>
    /// Interaction logic for XemBenhAnBase.xaml
    /// </summary>
    public class XemBenhAnBase : UserControl
    {
        public static RoutedCommand KyTen = new RoutedCommand();
        public static RoutedCommand XuatHoSo = new RoutedCommand();

        public XemBenhAnBase()
        {
            this.CommandBindings.Add(new CommandBinding(KyTen, KyTen_Executed));
            this.CommandBindings.Add(new CommandBinding(XuatHoSo, XuatHoSo_Executed));
        }

        static XemBenhAnBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(XemBenhAnBase), new FrameworkPropertyMetadata(typeof(XemBenhAnBase)));
        }

        public virtual void KyTen_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }

        public virtual void XuatHoSo_Executed(object sender, ExecutedRoutedEventArgs e)
        {
        }
    }
}