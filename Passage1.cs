using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Lab12
{
	public class Passage1 : ContentPage
	{
        Label passage;
		public Passage1 ()
		{
            passage = new Label();
            ContentView contentView = new ContentView
            {
                Content = passage,
                BackgroundColor = Color.Yellow
            };
            contentView.SizeChanged += OnContentViewSizeChanged;
            Content = contentView;
        }

        void OnContentViewSizeChanged(object sender, EventArgs args)
        {
            View view = (View)sender;

            if (view.Width <= 0 || view.Height <= 0)
                return;

            passage.Text = "So they began working together, each squadron leader commanding individual pilots, " +
                               "Ender commanding the squadron leaders. They learned many ways of working together, " +
                               "as the simulator forced them to try different situations. Sometimes the simulator " +
                               "gave them a larger fleet to work with; Ender set them up then in three or four " +
                               "toons that consisted of three or four squadrons each. Sometimes the simulator gave " +
                               "them a single starship with its twelve fighters, and he chose three squadron leaders. ";
            

            FontCalc lowerFontCalc = new FontCalc(passage, 15, view.Width);
            FontCalc upperFontCalc = new FontCalc(passage, 150, view.Width);

            while (upperFontCalc.FontSize - lowerFontCalc.FontSize > 1)
            {
                double fontSize = (lowerFontCalc.FontSize - upperFontCalc.FontSize) / 2;

                FontCalc newFontCalc = new FontCalc(passage, fontSize, view.Width);
                if (newFontCalc.TextHeight > view.Height)
                {
                    upperFontCalc = newFontCalc;
                }
                else
                {
                    lowerFontCalc = newFontCalc;
                }

                passage.FontSize = lowerFontCalc.FontSize;
            };
        }
    }
}
