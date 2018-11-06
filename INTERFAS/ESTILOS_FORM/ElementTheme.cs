using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

/// <summary>
/// Element Theme
/// Created by Earn
/// From HackForums
/// Converted to C# by Sloth (I am Lildeo on HF)
/// From NextGenUpdate
/// </summary>
/// <remarks></remarks>

enum Mouse
{
    None = 0,
    Over = 1,
    Down = 2
}


class ElementTheme : ContainerControl
{

    #region " Declarations "
    bool _Down = false;
    int _Header = 30;
    Point _MousePoint;
    #endregion
    #region " MouseStates "

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _Down = false;
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        if (e.Location.Y < _Header && e.Button == System.Windows.Forms.MouseButtons.Left)
        {
            _Down = true;
            _MousePoint = e.Location;
        }
    }

    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        if (_Down == true)
        {
            int xDiff = _MousePoint.X - MousePosition.X;
            int yDiff = _MousePoint.Y - MousePosition.Y;

            // Set the new point
            int x = this.Location.X - xDiff;
            int y = this.Location.Y - yDiff;
            ParentForm.Location = new Point(x, y);
        }
    }

    #endregion

    #region " Properties "

    private bool _CenterText;
    public bool CenterText
    {
        get
        {
            bool functionReturnValue = false;
            return functionReturnValue;
        }
        set { _CenterText = value; }
    }


    #endregion

    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        ParentForm.FormBorderStyle = FormBorderStyle.None;
        ParentForm.TransparencyKey = Color.Fuchsia;
        Dock = DockStyle.Fill;
        Invalidate();
    }

    public ElementTheme()
    {
        BackColor = Color.FromArgb(41, 41, 41);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;
        G.Clear(Color.FromArgb(32, 32, 32));
        G.FillRectangle(new SolidBrush(BackColor), new Rectangle(9, _Header, Width - 18, Height - _Header - 9));
        if (_CenterText == true)
        {
            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Arial", 11), Brushes.White, new RectangleF(0, 0, Width, _Header), _StringF);
        }
        else
        {
            G.DrawString(Text, new Font("Arial", 11), Brushes.White, new Point(8, 7));
        }
    }
}

class ElementButton : Control
{

    #region " Declarations "
    #endregion
    private Mouse _State;

    #region " MouseStates "
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _State = Mouse.Over;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _State = Mouse.None;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _State = Mouse.Down;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _State = Mouse.Over;
        Invalidate();
    }
    #endregion

    #region " Properties "

    private Color _BaseColor = Color.FromArgb(231, 75, 60);
    public Color BaseColor
    {
        get { return _BaseColor; }
        set { _BaseColor = value; }
    }


    #endregion

    public ElementButton()
    {
        Size = new Size(90, 30);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;
        G.Clear(_BaseColor);

        switch (_State)
        {
            case Mouse.Over:
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(0, 0, Width, Height));
                break;

            case Mouse.Down:
                G.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), new Rectangle(0, 0, Width, Height));
                break;
        }

        StringFormat _StringF = new StringFormat();
        _StringF.Alignment = StringAlignment.Center;
        _StringF.LineAlignment = StringAlignment.Center;
        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 0, Width, Height), _StringF);

    }

}
class ElementGroupBox : ContainerControl
{

    #region " Properties "
    private Color _SideColor = Color.FromArgb(231, 75, 60);
    public Color SideColor
    {
        get { return _SideColor; }
        set { _SideColor = value; }
    }

    #endregion

    public ElementGroupBox()
    {
        Size = new Size(200, 100);
        BackColor = Color.FromArgb(32, 32, 32);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;
        G.Clear(Color.FromArgb(32, 32, 32));

        G.FillRectangle(new SolidBrush(_SideColor), new Rectangle(0, 0, 7, Height));
        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new Point(10, 4));
    }
}
class ElementRadioButton : Control
{

    #region " Variables "

    private Mouse _State;
    private bool _Checked;

    #endregion

    #region " Properties "
    public bool Checked
    {
        get { return _Checked; }
        set
        {
            _Checked = value;
            InvalidateControls();
            if (CheckedChanged != null)
            {
                CheckedChanged(this);
            }
            Invalidate();
        }
    }

    private Color _CheckedColor = Color.FromArgb(231, 75, 60);
    public Color CheckedColor
    {
        get { return _CheckedColor; }
        set { _CheckedColor = value; }
    }


    #endregion

    #region " Events "
    public event CheckedChangedEventHandler CheckedChanged;
    public delegate void CheckedChangedEventHandler(object sender);
    protected override void OnClick(EventArgs e)
    {
        if (!_Checked)
            Checked = true;
        base.OnClick(e);
    }
    private void InvalidateControls()
    {
        if (!IsHandleCreated || !_Checked)
            return;
        foreach (Control C in Parent.Controls)
        {
            if (!object.ReferenceEquals(C, this) && C is ElementRadioButton)
            {
                ((ElementRadioButton)C).Checked = false;
                Invalidate();
            }
        }
    }
    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        InvalidateControls();
    }


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 16;
    }
    #endregion

    #region " Mouse States "

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _State = Mouse.Down;
        Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _State = Mouse.Over;
        Invalidate();
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _State = Mouse.Over;
        Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _State = Mouse.None;
        Invalidate();
    }

    #endregion

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;
        G.SmoothingMode = SmoothingMode.HighQuality;
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        G.Clear(Parent.BackColor);
        G.FillEllipse(Brushes.White, new Rectangle(0, 0, 15, 15));
        if (Checked)
        {
            G.FillEllipse(new SolidBrush(_CheckedColor), new Rectangle(2, 2, 11, 11));
        }
        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new Point(20, 0));
    }
}
class ElementCheckBox : Control
{

    #region " Variables "

    private Mouse _State;
    private bool _Checked;

    #endregion

    #region " Properties "
    public bool Checked
    {
        get { return _Checked; }
        set
        {
            _Checked = value;
            if (CheckedChanged != null)
            {
                CheckedChanged(this);
            }
            Invalidate();
        }
    }

    private Color _CheckedColor = Color.FromArgb(231, 75, 60);
    public Color CheckedColor
    {
        get { return _CheckedColor; }
        set { _CheckedColor = value; }
    }
    #endregion

    #region " Events "
    public event CheckedChangedEventHandler CheckedChanged;
    public delegate void CheckedChangedEventHandler(object sender);
    protected override void OnClick(EventArgs e)
    {
        if (Checked == true)
        {
            Checked = false;
            return;
        }
        if (Checked == false)
        {
            Checked = true;
            return;
        }

        base.OnClick(e);
    }


    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 16;
    }
    #endregion

    #region " Mouse States "

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _State = Mouse.Down;
        Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _State = Mouse.Over;
        Invalidate();
    }
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _State = Mouse.Over;
        Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _State = Mouse.None;
        Invalidate();
    }

    #endregion

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;
        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        G.Clear(Parent.BackColor);
        G.FillRectangle(Brushes.White, new Rectangle(0, 0, 15, 15));
        if (Checked == true)
        {
            G.FillRectangle(new SolidBrush(_CheckedColor), new Rectangle(2, 2, 11, 11));
        }
        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new Point(20, 0));
    }
}

class ElementProgressBar : Control
{

    #region " Variables "
    private int _Value = 0;
    private int _Maximum = 100;
    #endregion

    #region " Properties "
    [Category("Control")]
    public int Maximum
    {
        get { return _Maximum; }
        set
        {
            if (value < _Value)
            {
                _Value = value;
            }
            _Maximum = value;
            Invalidate();
        }
    }
    [Category("Control")]
    public int Value
    {
        get
        {
            if (_Value == 0)
            {

                Invalidate();
                return 0;
            }
            else
            {
                Invalidate();
                return _Value;
            }
        }
        set
        {
            if (value > _Maximum)
            {
                value = _Maximum;
                Invalidate();
            }
            _Value = value;
            Invalidate();
        }
    }

    private Color _ProgressColor = Color.FromArgb(231, 75, 60);
    public Color ProgressColor
    {
        get { return _ProgressColor; }
        set { _ProgressColor = value; }
    }


    #endregion

    #region " Events "
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Height = 25;
    }

    protected override void CreateHandle()
    {
        base.CreateHandle();
        Height = 25;
    }

    public void Increment(int Amount)
    {
        Value += Amount;
    }
    #endregion

    public ElementProgressBar()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;

        G.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        G.SmoothingMode = SmoothingMode.HighQuality;
        G.PixelOffsetMode = PixelOffsetMode.HighQuality;

        G.Clear(Parent.BackColor);
        decimal Math1 = (decimal)_Value / _Maximum * Width;
        int ProgVal = Convert.ToInt32(Math1);
        G.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, Width, Height));
        G.FillRectangle(new SolidBrush(_ProgressColor), new Rectangle(0, 0, ProgVal, Height));
        G.InterpolationMode = InterpolationMode.HighQualityBicubic;
    }

}




[DefaultEvent("TextChanged")]
class ElementTextBox : Control
{

    #region " Variables"
    #endregion
    private System.Windows.Forms.TextBox _TextBox;

    #region " Properties"

    private HorizontalAlignment _TextAlign = HorizontalAlignment.Left;
    [Category("Options")]
    public HorizontalAlignment TextAlign
    {
        get { return _TextAlign; }
        set
        {
            _TextAlign = value;
            if (_TextBox != null)
            {
                _TextBox.TextAlign = value;
            }
        }
    }
    private int _MaxLength = 32767;
    [Category("Options")]
    public int MaxLength
    {
        get { return _MaxLength; }
        set
        {
            _MaxLength = value;
            if (_TextBox != null)
            {
                _TextBox.MaxLength = value;
            }
        }
    }
    private bool _ReadOnly;
    [Category("Options")]
    public bool ReadOnly
    {
        get { return _ReadOnly; }
        set
        {
            _ReadOnly = value;
            if (_TextBox != null)
            {
                _TextBox.ReadOnly = value;
            }
        }
    }
    private bool _UseSystemPasswordChar;
    [Category("Options")]
    public bool UseSystemPasswordChar
    {
        get { return _UseSystemPasswordChar; }
        set
        {
            _UseSystemPasswordChar = value;
            if (_TextBox != null)
            {
                _TextBox.UseSystemPasswordChar = value;
            }
        }
    }
    private bool _Multiline;
    [Category("Options")]
    public bool Multiline
    {
        get { return _Multiline; }
        set
        {
            _Multiline = value;
            if (_TextBox != null)
            {
                _TextBox.Multiline = value;

                if (value)
                {
                    _TextBox.Height = Height - 11;
                }
                else
                {
                    Height = _TextBox.Height + 11;
                }

            }
        }
    }
    [Category("Options")]
    public override string Text
    {
        get { return base.Text; }
        set
        {
            base.Text = value;
            if (_TextBox != null)
            {
                _TextBox.Text = value;
            }
        }
    }
    [Category("Options")]
    public override Font Font
    {
        get { return base.Font; }
        set
        {
            base.Font = value;
            if (_TextBox != null)
            {
                _TextBox.Font = value;
                _TextBox.Location = new Point(3, 5);
                _TextBox.Width = Width - 6;

                if (!_Multiline)
                {
                    Height = _TextBox.Height + 11;
                }
            }
        }
    }

    private Color _BorderColor = Color.FromArgb(231, 75, 60);
    public Color BorderColor
    {
        get { return _BorderColor; }
        set { _BorderColor = value; }
    }


    #endregion

    #region " Events "
    protected override void OnCreateControl()
    {
        base.OnCreateControl();
        if (!Controls.Contains(_TextBox))
        {
            Controls.Add(_TextBox);
        }
    }
    private void OnBaseTextChanged(object s, EventArgs e)
    {
        Text = _TextBox.Text;
    }
    private void OnBaseKeyDown(object s, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.A)
        {
            _TextBox.SelectAll();
            e.SuppressKeyPress = true;
        }
        if (e.Control && e.KeyCode == Keys.C)
        {
            _TextBox.Copy();
            e.SuppressKeyPress = true;
        }
    }
    protected override void OnResize(EventArgs e)
    {
        _TextBox.Location = new Point(5, 5);
        _TextBox.Width = Width - 10;

        if (_Multiline)
        {
            _TextBox.Height = Height - 11;
        }
        else
        {
            Height = _TextBox.Height + 11;
        }
        base.OnResize(e);
    }

    #endregion

    public ElementTextBox()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);
        DoubleBuffered = true;

        BackColor = Color.Transparent;

        _TextBox = new System.Windows.Forms.TextBox();
        _TextBox.Font = new Font("Segoe UI", 10);
        _TextBox.Text = Text;
        _TextBox.BackColor = Color.FromArgb(32, 32, 32);
        _TextBox.ForeColor = Color.White;
        _TextBox.MaxLength = _MaxLength;
        _TextBox.Multiline = _Multiline;
        _TextBox.ReadOnly = _ReadOnly;
        _TextBox.UseSystemPasswordChar = _UseSystemPasswordChar;
        _TextBox.BorderStyle = BorderStyle.None;
        _TextBox.Location = new Point(5, 5);
        _TextBox.Width = Width - 10;

        _TextBox.Cursor = Cursors.IBeam;

        if (_Multiline)
        {
            _TextBox.Height = Height - 11;
        }
        else
        {
            Height = _TextBox.Height + 11;
        }

        _TextBox.TextChanged += OnBaseTextChanged;
        _TextBox.KeyDown += OnBaseKeyDown;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;
        G.Clear(Color.FromArgb(32, 32, 32));
        G.DrawRectangle(new Pen(_BorderColor), new Rectangle(0, 0, Width - 1, Height - 1));
    }
}
class ElementClose : Control
{

    #region " Declarations "
    #endregion
    private Mouse _State;

    #region " MouseStates "
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _State = Mouse.Over;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _State = Mouse.None;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _State = Mouse.Down;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _State = Mouse.Over;
        Invalidate();
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        Environment.Exit(0);
    }
    #endregion

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(12, 12);
    }

    public ElementClose()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
        Size = new Size(12, 12);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;

        G.Clear(Color.FromArgb(32, 32, 32));

        StringFormat _StringF = new StringFormat();
        _StringF.Alignment = StringAlignment.Center;
        _StringF.LineAlignment = StringAlignment.Center;

        G.DrawString("r", new Font("Marlett", 11), Brushes.White, new RectangleF(0, 0, Width, Height), _StringF);

        switch (_State)
        {
            case Mouse.Over:
                G.DrawString("r", new Font("Marlett", 11), new SolidBrush(Color.FromArgb(25, Color.White)), new RectangleF(0, 0, Width, Height), _StringF);
                break;

            case Mouse.Down:
                G.DrawString("r", new Font("Marlett", 11), new SolidBrush(Color.FromArgb(40, Color.Black)), new RectangleF(0, 0, Width, Height), _StringF);
                break;

        }

    }

}
class ElementMini : Control
{

    #region " Declarations "
    #endregion
    private Mouse _State;

    #region " MouseStates "
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _State = Mouse.Over;
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _State = Mouse.None;
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _State = Mouse.Down;
        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _State = Mouse.Over;
        Invalidate();
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        FindForm().WindowState = FormWindowState.Minimized;
    }
    #endregion

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        Size = new Size(12, 12);
    }

    public ElementMini()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        DoubleBuffered = true;
        Size = new Size(12, 12);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        dynamic G = e.Graphics;

        G.Clear(Color.FromArgb(32, 32, 32));

        StringFormat _StringF = new StringFormat();
        _StringF.Alignment = StringAlignment.Center;
        _StringF.LineAlignment = StringAlignment.Center;

        G.DrawString("0", new Font("Marlett", 11), Brushes.White, new RectangleF(0, 0, Width, Height), _StringF);

        switch (_State)
        {
            case Mouse.Over:
                G.DrawString("0", new Font("Marlett", 11), new SolidBrush(Color.FromArgb(25, Color.White)), new RectangleF(0, 0, Width, Height), _StringF);
                break;

            case Mouse.Down:
                G.DrawString("0", new Font("Marlett", 11), new SolidBrush(Color.FromArgb(40, Color.Black)), new RectangleF(0, 0, Width, Height), _StringF);
                break;

        }

    }

}