﻿namespace Lampac.Models.AppConf
{
    public class WebConf
    {
        public bool autoupdate { get; set; }

        public string index { get; set; }

        public InitPlugins initPlugins { get; set; } = new InitPlugins();
}
}
