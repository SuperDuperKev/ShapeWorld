namespace ShapeWorld.Domain.Models{
   public class Square : Rectangle{
      private double edgeLength;
      public override double Length {
         get{
         return edgeLength;
      }
      set{
         edgeLength = value;
      }
      }
      public override double Width {
         get{
         return edgeLength;
      }
      set{
         edgeLength = value;
      }
      }
      public override double Perimeter(){
         return 4 * Length;
      }
   }
    
}