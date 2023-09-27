namespace ClassLibrary2Practos
{
    public class CalculDelta
    {
        public double CalculateDelta(double Oldx, double Newy) 
        {  
            double delta = Newy - Oldx;
            return (delta/Oldx)*100; 
        }

    }
}