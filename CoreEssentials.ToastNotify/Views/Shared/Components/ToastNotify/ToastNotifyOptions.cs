using System;
using System.Collections.Generic;
using System.Text;

namespace CoreEssentials.ToastNotify.Views.Shared.Components.ToastNotify
{
    public class Position
    {
        public string x { get; set; }
        public string y { get; set; }
    }

    public class Icon
    {
        public string className { get; set; }
        public string tagName { get; set; }
        public string text { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
        public string background { get; set; }
        public string className { get; set; }
        public Icon icon { get; set; }
    }

    public class ToastNotifyOptions
    {
        public ToastNotifyOptions(int durationInSeconds = 5, string toastPosition = "right-bottom", bool isDismissible = true)
        {
            duration = (durationInSeconds>1) ? durationInSeconds*1000 : 5000;
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
           
            types = new List<Type>()
            {
                new Type
                {
                    type = "success",
                    background = "#28a745"
                },
                new Type
                {
                    type = "error",
                    background = "#dc3545"
                },
                new Type
                {
                    type = "warning",
                    background = "#ffc107",
                    className = "text-dark"
                },
                new Type
                {
                    type = "info",
                    background = "#17a2b8"
                }
            };

        }
        public int duration { get; set; }
        public Position position { get; set; }
        public bool dismissible { get; set; } = true;
        public bool ripple { get; set; } = true;
        public List<Type> types { get; set; }
    }
}
