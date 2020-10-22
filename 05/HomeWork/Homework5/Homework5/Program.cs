using System;

namespace Homework5
{
    class Program
    {
        enum Figures: int
        {
            Round = 1,
            Triangle,
            Rectangle,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter figure type number,"+
                " when 1 is a round, 2 is a triangle" +
                " and 3 is a rectangle: ");
            //string enteredValue = Console.ReadLine();

            try
            {
                Figures figureType = Enum.Parse<Figures>(Console.ReadLine());
                float figureSquare = 0;
                float figurePerimeter = 0;
                switch ((int)figureType)
                {
                    case 1:
                        Console.WriteLine("Enter radius, please: ");
                        float radiusOfRound = Single.Parse(Console.ReadLine());
                        figureSquare = MathF.PI * radiusOfRound * radiusOfRound;
                        figureSquare = MathF.Round(figureSquare, 2);
                        figurePerimeter = 2 * MathF.PI * radiusOfRound;
                        figurePerimeter = MathF.Round(figurePerimeter, 2);
                        break;
                    case 2:
                        Console.WriteLine("Enter side length, please:");
                        float sideOfTriangle = Single.Parse(Console.ReadLine());
                        figureSquare = MathF.Sqrt(3) * sideOfTriangle * sideOfTriangle / 4;
                        figureSquare = MathF.Round(figureSquare, 2);
                        figurePerimeter = 3 * sideOfTriangle;
                        break;
                    case 3:
                        Console.WriteLine("Enter length, please: ");
                        float lengthOfRectangle = Single.Parse(Console.ReadLine());
                        Console.WriteLine("Enter width, please: ");
                        float widthOfRectangle = Single.Parse(Console.ReadLine());
                        figureSquare = lengthOfRectangle * widthOfRectangle;
                        figurePerimeter = (lengthOfRectangle + widthOfRectangle) * 2;
                        break;
                    default:
                        Console.WriteLine("Sorry, but you should enter only 1, 2 or 3. " +
                        "Launch the program again and try once more.");
                        break;
                }

                Console.WriteLine("Square of this figure is: " + figureSquare);
                Console.WriteLine("Perimeter of this figure is: " + figurePerimeter);
            }

            catch (ArgumentException e)
            {
                Console.WriteLine("Sorry, but you should enter only 1, 2 or 3. " +
                  "Launch the program again and try once more. \n" + e.Message );
            }
            
            catch (OverflowException o)
            {
                Console.WriteLine("Entered values are too large! \n" + o.Message);
            }

            catch (FormatException o)
            {
                Console.WriteLine("You should use ',' for float numbers. \n" + o.Message);
            }

        }
    }
}
