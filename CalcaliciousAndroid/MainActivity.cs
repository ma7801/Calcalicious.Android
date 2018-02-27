using System.Collections.Generic;
using Android.App;
using Android.Widget;
using Android.OS;

namespace CalcaliciousAndroid
{
    [Activity(Label = "CalcaliciousAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Dictionary<int, Button> numberButtons = new Dictionary<int, Button>
            {
                { 0, FindViewById<Button>(Resource.Id.button0) },
                { 1, FindViewById<Button>(Resource.Id.button1) },
                { 2, FindViewById<Button>(Resource.Id.button2) },
                { 3, FindViewById<Button>(Resource.Id.button3) },
                { 4, FindViewById<Button>(Resource.Id.button4) },
                { 5, FindViewById<Button>(Resource.Id.button5) },
                { 6, FindViewById<Button>(Resource.Id.button6) },
                { 7, FindViewById<Button>(Resource.Id.button7) },
                { 8, FindViewById<Button>(Resource.Id.button8) },
                { 9, FindViewById<Button>(Resource.Id.button9) }
            };

            TextView expression = FindViewById<TextView>(Resource.Id.textExpression);

            foreach (KeyValuePair<int, Button> curButton in numberButtons)
            {
                curButton.Value.Click += delegate { expression.Text += curButton.Key.ToString(); };
            };

            

            //***NOT finished here - need to add more buttons and what they do on click.
            // Also, starting a git repository would be good




        }

        private void NumberButtonHandler()
        {

        }

        private void Value_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

