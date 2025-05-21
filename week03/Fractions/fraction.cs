public class Fraction
{
    private int _top;
    private int _bottom;

    // No-argument constructor: 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // One-argument constructor: top/n, n = 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Two-argument constructor
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for Top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for Bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Return fraction as string (e.g. "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Return decimal value (e.g. 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}