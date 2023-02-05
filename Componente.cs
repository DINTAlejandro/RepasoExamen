class Componente
{
    public string Nombre { get; set; }
    
    public string Tipo { get; set; }
    
    public string Foto { get; set; }

    public int Precio { get; set; }

    public Componente(string nombre, string tipo, string foto, int precio)
    {
        this.nombre = nombre;
        this.tipo = tipo;
        this.foto = foto;
        this.precio = precio;
    }

    public static ObservableCollection<Componente> GetSamples()
    {
        var lista = new ObservableCollection<Componente>();
        lista.Add(new Componente("AMD Ryzen 7 5800X","Procesador", "AMD_Ryzen_7_5800X.jpg", 452));
        lista.Add(new Componente("Intel Core i7-11700K", "Procesador", "Intel_Core_i7_11700K.jpg", 365));
        lista.Add(new Componente("Gainward 471056224", "Tarjeta", "Gainward_471056224.jpg", 1719));
        lista.Add(new Componente("ASUS ROG Maximus XIII Extreme", "Placa base", "ASUS_ROG_Maximus_XIII_Extreme.jpg", 976));
        lista.Add(new Componente("ASRock X570 Creator", "Placa base", "ASRock_X570_Creator.jpg", 512));
        return lista;
    }   
}

