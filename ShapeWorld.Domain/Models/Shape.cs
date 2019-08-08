namespace ShapeWorld.Domain.Models
{
    public abstract class Shape{
       //backing fields
       //private int numberOfEdges;

       //properties
       public int NumberOfEdges{get;}

       //methods
       public virtual double Perimeter(){
          return 0;
       }

       public abstract double Area();

       public double Volume(){
          return 0;
       }

       //controllers
       public Shape(int edges){
          NumberOfEdges = edges;
       }
    }
}