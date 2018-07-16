using System;

namespace BaiTap01.Views
{

    public class MainViewMenuItem
    {
        public MainViewMenuItem()
        {
            TargetType = typeof(MainViewDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public Type TargetType { get; set; }
    }
}