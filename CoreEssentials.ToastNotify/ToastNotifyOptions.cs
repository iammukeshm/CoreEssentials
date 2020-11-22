using CoreEssentials.ToastNotify.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify
{
    public class ToastNotifyOptions
    {
        public ToastNotifyOptions(int durationInSeconds = 5, string toastPosition = ToastNotifyPositions.BottomRight, bool isDismissible = true)
        {
            duration = (durationInSeconds > 0) ? durationInSeconds * 1000 : 5000;
            dismissible = isDismissible;
            ripple = true;
            try
            {
                var positionArray = toastPosition.Split('-');
                position = new Position()
                {
                    x = (positionArray is null) ? "right" : positionArray[0],
                    y = (positionArray is null) ? "bottom" : positionArray[1]
                };
            }
            catch
            {
                position = new Position()
                {
                    x = "right",
                    y = "bottom"
                };
            }

            types = new List<Config>()
            {
                new Config
                {
                    type = "success",
                    background = "#28a745"
                },
                new Config
                {
                    type = "error",
                    background = "#dc3545"
                },
                new Config
                {
                    type = "warning",
                    background = "orange",
                    className = "text-dark",
                    icon = new Icon
                    {
                         className = "fa fa-warning text-dark",
                         tagName = "i",
                    }
                },
                new Config
                {
                    type = "info",
                    background = "#17a2b8",
                    icon = new Icon
                    {
                         className = "fa fa-info text-white",
                         tagName = "i",
                    }
                },
                new Config
                {
                    type = "custom",
                    background = "black"
                }
            };

        }
        public int duration { get; set; }
        public Position position { get; set; }
        public bool dismissible { get; set; } = true;
        public bool ripple { get; set; } = true;
        public List<Config> types { get; set; }
    }
}
