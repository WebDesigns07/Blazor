using System;

namespace BlazorDevExpress
{
    public class Game
    {
        public Club Home { get; set; }
        public Club Away { get; set; }
        public DateTime Time { get; set; }
        public string Judge { get; set; }
        public string Weather { get; set; }
    }
}
