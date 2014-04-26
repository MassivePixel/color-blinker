// Copyright 2014 Massive Pixel j.d.o.o.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
//    limitations under the License. 

using System.Collections.Generic;
using System.Windows.Media;

namespace MassivePixel.ColorMe.WP8.ViewModels
{
    public class MainViewModel
    {
        public List<ColorViewModel> Colors { get; set; }

        public MainViewModel()
        {
            Colors = new List<ColorViewModel>
            {
                new ColorViewModel {Color = HexColor(0xFFA4C400), Name="Lime"},
                new ColorViewModel {Color = HexColor(0xFF60A917), Name="Green"},
                new ColorViewModel {Color = HexColor(0xFF008A00), Name="Emerald"},
                new ColorViewModel {Color = HexColor(0xFF00ABA9), Name="Teal"},
                new ColorViewModel {Color = HexColor(0xFF1BA1E2), Name="Cyan"},
                new ColorViewModel {Color = HexColor(0xFF0050EF), Name="Cobalt"},
                new ColorViewModel {Color = HexColor(0xFF6A00FF), Name="Indigo"},
                new ColorViewModel {Color = HexColor(0xFFAA00FF), Name="Violet"},
                new ColorViewModel {Color = HexColor(0xFFF472D0), Name="Pink"},
                new ColorViewModel {Color = HexColor(0xFFD80073), Name="Magenta"},
                new ColorViewModel {Color = HexColor(0xFFA20025), Name="Crimson"},
                new ColorViewModel {Color = HexColor(0xFFE51400), Name="Red"},
                new ColorViewModel {Color = HexColor(0xFFFA6800), Name="Orange"},
                new ColorViewModel {Color = HexColor(0xFFF0A30A), Name="Amber"},
                new ColorViewModel {Color = HexColor(0xFFE3C800), Name="Yellow"},
                new ColorViewModel {Color = HexColor(0xFF825A2C), Name="Brown"},
                new ColorViewModel {Color = HexColor(0xFF6D8764), Name="Olive"},
                new ColorViewModel {Color = HexColor(0xFF647687), Name="Steel"},
                new ColorViewModel {Color = HexColor(0xFF76608A), Name="Mauve"},
                new ColorViewModel {Color = HexColor(0xFFA0522D), Name="Sienna"},
            };
        }

        private Color HexColor(uint color)
        {
            return Color.FromArgb((byte)(color >> 24), (byte)(color >> 16), (byte)(color >> 8), (byte)(color & 0xff));
        }
    }
}
