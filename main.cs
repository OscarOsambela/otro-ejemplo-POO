using System;

class MainClass {
  public static void Main (string[] args) {
  Persona obj = new Persona();
  obj.setPersona();
  Console.WriteLine(obj.getPersona());

  Persona obj2 = new Persona("Francisco", "Osambela", true, "estudiante");
  obj2.setPersona2();
  Console.WriteLine(obj2.getPersona());

  Persona obj3 = new Persona(6, "Osambela", true, "profesor");
  Console.WriteLine(obj3.getPersona());
}

class Persona{

  //constructor
  public Persona(){
    edad = 40;
    nombre = "Oscar";
    apellido = "Osambela";
    estado = true;
    tipo = "estudiante";
  }
  //obj1
  public Persona(string par1, string par2, bool par3, string par4){
    edad = 2;
    nombre = par1;
    apellido = par2;
    estado = par3;
    tipo = par4;
  }
  //obj2
    public Persona(int par9, string par6, bool par7, string par8){
    edad = par9;
    nombre = "Vernita";
    apellido = par6;
    estado = par7;
    tipo = par8;
  }
  //metodo setter
  public void setPersona(){
    edad = 38;
    tipo = "profesor";
  }
  public void setPersona2(){
    edad = 5;
    tipo = "profesor";
  }
  //metodo getter
  public string getPersona(){
    return "Mi nombre es " + nombre + " " + apellido + " y tengo " + edad + " años.\n" 
    + "Estado: " + estado + "\n"
    + "Tipo perfil: " + tipo; 
  }

  private int edad;
  private string nombre;
  private string apellido;
  private bool estado;
  private string tipo;
}
}