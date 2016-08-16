using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _6._22ListView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<int> DataTimes = new List<int>();

        public ObservableCollection<Recording> MyMusic { get; set; }

        public MainPage()
        {
            for (int i = 1; i < 10; i++)
            {
                DataTimes.Add(i);
            }

            this.InitializeComponent();

            listView.DataContext = DataTimes;

            MyMusic = new ObservableCollection<Recording>();
            MyMusic.Add(new Recording("xiaoming", "222"));
            MyMusic.Add(new Recording("xiaowang", "333"));
            MyMusic.Add(new Recording("xiaohong", "444"));

            //ComboBox1.DataContext = MyMusic;

            this.DataContext = this;
        }
}
    
    

    public class Recording {
        public string name { get; set; }
        public string age { get; set; }
        public Recording(string name, string age) {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return name + " by " + age;
        }
    }
}
