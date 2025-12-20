using StructureProgramming;

Person person = new Person();


person.Breath();

Dog doggi = new Dog();

doggi.Comunicate();



ILivingBeings[] concept =
{
    person,
    doggi
}; 


foreach (var con in concept)
{
    con.Breath(); 
} 