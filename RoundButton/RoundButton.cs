namespace RoundButton
{
    public partial class RoundButton : RoundControl
    {
        public bool UseMouseOverBackColor { get; set; } = false;
        public Color MouseOverBackColor { get; set; }
        private Color backgroundColor;
        public RoundButton() => InitializeComponent();
        private void RoundButton_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = BackgroundColor;
            backgroundColor = BackgroundColor;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            button1.Location = new Point(20, 20);
            button1.Width = Width - 40;
            button1.Height = Height - 40;
            button1.BackColor = BackgroundColor;
        }

        private void button1_Click(object sender, EventArgs e) => InvokeOnClick(this, e);

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (UseMouseOverBackColor && MouseOverBackColor != backgroundColor)
                BackgroundColor = button1.BackColor = MouseOverBackColor;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (UseMouseOverBackColor && MouseOverBackColor != backgroundColor)
                BackgroundColor = button1.BackColor = backgroundColor;
        }
    }
}
