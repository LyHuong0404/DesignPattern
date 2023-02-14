public abstract class Burger:Item {

   public Packing packing() {
      return new Wrapper();
   }

     public String name(){
         return "Veg Burger";
     }
   public abstract float price();
}