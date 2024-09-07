namespace RoundButton
{
    public partial class RoundButton : RoundControl
    {
        public RoundButton() => InitializeComponent();
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            button1.Location = new Point(20, 20);
            button1.Width = Width - 40;
            button1.Height = Height - 40;
            button1.BackColor = BackgroundColor;
            button1.FlatAppearance.MouseOverBackColor = BackgroundColor;
            button1.FlatAppearance.MouseDownBackColor = BackgroundColor;
            button1.FlatAppearance.BorderColor = BackgroundColor;
        }

        private void button1_Click(object sender, EventArgs e) => InvokeOnClick(this, e);
    }
}
