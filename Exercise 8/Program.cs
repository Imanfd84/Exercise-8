//iman fatahi
//tamrin shomare 8 (gav dari)



using System.Reflection;

Animal cow1 = new Animal()
{
    name = "cow 1",
    type = "mamal",
    gender = "male",
    maximumage = 7,
    age = 1,
    weight = 800,
    fatweight = 50,
    dailystool = 1,
    typeoffood = "yonje",
    foodvolume = 2,
    patient = "not patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",unit="kilogram",price = 480000 }

    }
};

Animal cow2 = new Animal()
{
    name = "cow 2",
    type = "mamal",
    gender = "female",
    maximumage = 7,
    age = 2.5,
    weight = 850,
    fatweight = 56,
    dailystool = 0.5,
    typeoffood = "yonje",
    foodvolume = 1.5,
    patient = "patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",unit="litr",price = 40000,dailyamount=1 }

    }
};

Animal cow3 = new Animal()
{

    name = "cow 3",
    type = "mamal",
    gender = "female",
    maximumage = 7,
    age = 3,
    weight = 700,
    fatweight = 67,
    dailystool = 1.5,
    typeoffood = "yonje",
    foodvolume = 2.25,
    patient = "patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",unit="litr",price = 40000,dailyamount=1 }

    }

};
Animal cow4 = new Animal()
{

    name = "cow 4",
    type = "mamal",
    gender = "female",
    maximumage = 7,
    age = 3,
    weight = 900,
    fatweight = 90,
    dailystool = 3,
    typeoffood = "ghalat",
    foodvolume = 5,
    patient = " not patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",unit="litr",price = 80000,dailyamount=1.75 }

    }

};
Animal cow5 = new Animal()
{

    name = "cow 5",
    type = "mamal",
    gender = "male",
    maximumage = 7,
    age = 5,
    weight = 965,
    fatweight = 100,
    dailystool = 1.75,
    typeoffood = "ghalat",
    foodvolume = 3.75,
    patient = " not patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",unit="kilogram",price = 480000, }

    }



};


Animal cow6 = new Animal()
{

    name = "cow 6",
    type = "mamal",
    gender = "female",
    maximumage = 7,
    age = 5,
    weight = 1175,
    fatweight = 127,
    dailystool = 3,
    typeoffood = "yonje",
    foodvolume = 4,
    patient = " not patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",unit="litr",price = 80000,dailyamount=2 }

    }


};
Animal cow7 = new Animal()
{

    name = "cow 7",
    type = "mamal",
    gender = "female",
    maximumage = 7,
    age = 6,
    weight = 1200,
    fatweight = 135,
    dailystool = 4,
    typeoffood = "yonje",
    foodvolume = 5,
    patient = "patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "milk",unit="litr",price = 40000,dailyamount=0.5 }

    }


};

Animal cow8 = new Animal()
{

    name = "cow 8",
    type = "mamal",
    gender = "male",
    maximumage = 7,
    age = 7,
    weight = 650,
    fatweight = 88,
    dailystool = 3.4,
    typeoffood = "yonje",
    foodvolume = 4.6,
    patient = " not patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",unit="kilogram",price = 480000 }

    }

};
Animal cow9 = new Animal()
{

    name = "cow 9",
    type = "mamal",
    gender = "male",
    maximumage = 7,
    age = 4,
    weight = 756,
    fatweight = 99,
    dailystool = 2.6,
    typeoffood = "yonje",
    foodvolume = 3.4,
    patient = "patient",
    skin = "charm",
    products = new List<Product>()
    {
       new Product(){name = "meat",unit="kilogram",price = 200000 }

    }


};
Animal cow10 = new Animal()
{

    name = "cow 10",
    type = "mamal",
    gender = "female",
    maximumage = 7,
    age = 3,
    weight = 880,
    fatweight = 106,
    dailystool = 2.25,
    typeoffood = "yonje",
    foodvolume = 2,
    patient = " not patient",
    skin = "charm",
    products = new List<Product>()
    {
        new Product(){name = "milk",unit="litr",price = 80000,dailyamount=2.5 }

    }

};


Console.WriteLine("choose one of these options:");
Console.WriteLine("1 = moshakhasat gav ha / 2 = sood goosht gav nar / 3 = sood rozane gav made / 4 = daramad rozane madfo / 5 = mizan hazine rozane / 6 = mizan sood  / 7 = takhmin avarde mali ta akhar omr / 8 = takhmin sood gav dar n sal ayande");
int x = Convert.ToInt32(Console.ReadLine());
if (x == 1)

{
    
    Console.WriteLine(cow1.name+"="+"type:"+cow1.type+",gender:"+cow1.gender+",maximumage:"+cow1.age+",age:"+cow1.age+",weight:"+cow1.weight+",fatweight:"+cow1.fatweight+",daily stool:"+cow1.dailystool+",type of food:"+cow1.typeoffood+",foodvolume:"+cow1.foodvolume+",patient:"+cow1.patient+",skin:"+cow1.skin);
    Console.WriteLine(cow2.name + "=" + "type:" + cow2.type + ",gender:" + cow2.gender + ",maximumage:" + cow2.age + ",age:" + cow2.age + ",weight:" + cow2.weight + ",fatweight:" + cow2.fatweight + ",daily stool:" + cow2.dailystool + ",type of food:" + cow2.typeoffood + ",foodvolume:" + cow1.foodvolume + ",patient:" + cow2.patient + ",skin:" + cow2.skin);
    Console.WriteLine(cow3.name + "=" + "type:" + cow3.type + ",gender:" + cow3.gender + ",maximumage:" + cow3.age + ",age:" + cow3.age + ",weight:" + cow3.weight + ",fatweight:" + cow3.fatweight + ",daily stool:" + cow3.dailystool + ",type of food:" + cow3.typeoffood + ",foodvolume:" + cow3.foodvolume + ",patient:" + cow3.patient + ",skin:" + cow3.skin);
    Console.WriteLine(cow4.name + "=" + "type:" + cow4.type + ",gender:" + cow4.gender + ",maximumage:" + cow4.age + ",age:" + cow4.age + ",weight:" + cow4.weight + ",fatweight:" + cow4.fatweight + ",daily stool:" + cow4.dailystool + ",type of food:" + cow4.typeoffood + ",foodvolume:" + cow4.foodvolume + ",patient:" + cow4.patient + ",skin:" + cow4.skin);
    Console.WriteLine(cow5.name + "=" + "type:" + cow5.type + ",gender:" + cow5.gender + ",maximumage:" + cow5.age + ",age:" + cow5.age + ",weight:" + cow5.weight + ",fatweight:" + cow5.fatweight + ",daily stool:" + cow5.dailystool + ",type of food:" + cow5.typeoffood + ",foodvolume:" + cow5.foodvolume + ",patient:" + cow5.patient + ",skin:" + cow5.skin);
    Console.WriteLine(cow6.name + "=" + "type:" + cow6.type + ",gender:" + cow6.gender + ",maximumage:" + cow6.age + ",age:" + cow6.age + ",weight:" + cow6.weight + ",fatweight:" + cow6.fatweight + ",daily stool:" + cow6.dailystool + ",type of food:" + cow6.typeoffood + ",foodvolume:" + cow6.foodvolume + ",patient:" + cow6.patient + ",skin:" + cow6.skin);
    Console.WriteLine(cow7.name + "=" + "type:" + cow7.type + ",gender:" + cow7.gender + ",maximumage:" + cow7.age + ",age:" + cow7.age + ",weight:" + cow7.weight + ",fatweight:" + cow7.fatweight + ",daily stool:" + cow7.dailystool + ",type of food:" + cow7.typeoffood + ",foodvolume:" + cow7.foodvolume + ",patient:" + cow7.patient + ",skin:" + cow7.skin);
    Console.WriteLine(cow8.name + "=" + "type:" + cow8.type + ",gender:" + cow8.gender + ",maximumage:" + cow8.age + ",age:" + cow8.age + ",weight:" + cow8.weight + ",fatweight:" + cow8.fatweight + ",daily stool:" + cow8.dailystool + ",type of food:" + cow8.typeoffood + ",foodvolume:" + cow8.foodvolume + ",patient:" + cow8.patient + ",skin:" + cow8.skin);
    Console.WriteLine(cow9.name + "=" + "type:" + cow9.type + ",gender:" + cow9.gender + ",maximumage:" + cow9.age + ",age:" + cow9.age + ",weight:" + cow9.weight + ",fatweight:" + cow9.fatweight + ",daily stool:" + cow9.dailystool + ",type of food:" + cow9.typeoffood + ",foodvolume:" + cow9.foodvolume + ",patient:" + cow9.patient + ",skin:" + cow9.skin);
    Console.WriteLine(cow10.name + "=" + "type:" + cow10.type + ",gender:" + cow10.gender + ",maximumage:" + cow10.age + ",age:" + cow10.age + ",weight:" + cow10.weight + ",fatweight:" + cow10.fatweight + ",daily stool:" + cow10.dailystool + ",type of food:" + cow10.typeoffood + ",foodvolume:" + cow10.foodvolume + ",patient:" + cow10.patient + ",skin:" + cow10.skin);
}

if(x == 2)
{

    Console.WriteLine("sood in gav="+cow1.name+":"+((cow1.weight-cow1.fatweight)*480000));
    Console.WriteLine("sood in gav=" + cow5.name + ":" + ((cow5.weight - cow5.fatweight) * 480000));
    Console.WriteLine("sood in gav=" + cow8.name + ":" + ((cow8.weight - cow8.fatweight) * 480000));
    Console.WriteLine("sood in gav=" + cow9.name + ":" + ((cow9.weight - cow9.fatweight) * 200000));

}

if (x ==3)
{
    Console.WriteLine( cow2.name+":"+(1*40000));
    Console.WriteLine( cow3.name + ":" + (1 * 40000));
    Console.WriteLine( cow4.name + ":" + (1.75 * 80000));
    Console.WriteLine( cow6.name + ":" + (2 * 80000));
    Console.WriteLine( cow7.name + ":" + (0.5 * 40000));
    Console.WriteLine( cow10.name + ":" + (2.5 * 80000));
}
if (x == 4)
{

    Console.WriteLine(cow1.name + ":" +(cow1.dailystool*20000));
    Console.WriteLine(cow2.name + ":" + (cow2.dailystool*20000));
    Console.WriteLine(cow3.name + ":" + (cow3.dailystool * 20000));
    Console.WriteLine(cow4.name + ":" + (cow4.dailystool * 20000));
    Console.WriteLine(cow5.name + ":" + (cow5.dailystool * 20000));
    Console.WriteLine(cow6.name + ":" + (cow6.dailystool * 20000));
    Console.WriteLine(cow7.name + ":" + (cow7.dailystool * 20000));
    Console.WriteLine(cow8.name + ":" + (cow8.dailystool * 20000));
    Console.WriteLine(cow9.name + ":" + (cow9.dailystool * 20000));
    Console.WriteLine(cow10.name + ":" + (cow10.dailystool * 20000));
  


}
if (x == 5)
{

    Console.WriteLine(cow1.name+":"+(cow1.foodvolume*10000));
    Console.WriteLine(cow2.name + ":" + (cow2.foodvolume * 10000));
    Console.WriteLine(cow3.name + ":" + (cow3.foodvolume * 10000));
    Console.WriteLine(cow4.name + ":" + (cow4.foodvolume * 10000));
    Console.WriteLine(cow5.name + ":" + (cow5.foodvolume * 10000));
    Console.WriteLine(cow6.name + ":" + (cow6.foodvolume * 10000));
    Console.WriteLine(cow7.name + ":" + (cow7.foodvolume * 10000));
    Console.WriteLine(cow8.name + ":" + (cow8.foodvolume * 10000));
    Console.WriteLine(cow9.name + ":" + (cow9.foodvolume * 10000));
    Console.WriteLine(cow10.name + ":" + (cow10.foodvolume * 10000));



}
if (x ==6)
{
    Console.WriteLine(cow1.name +":"+(((cow1.weight-cow1.fatweight)*480000)-(cow1.foodvolume*10000)));
    Console.WriteLine(cow2.name+":"+((40000)-(cow2.foodvolume*10000)));
    Console.WriteLine(cow3.name+":"+((40000)-(cow3.foodvolume*10000)));
    Console.WriteLine(cow4.name+":"+((1.75*80000)-(cow4.foodvolume*10000)));
    Console.WriteLine(cow5.name + ":" + (((cow5.weight - cow5.fatweight) * 480000) - (cow5.foodvolume * 10000)));
    Console.WriteLine(cow6.name + ":" + ((2 * 80000) - (cow6.foodvolume * 10000)));
    Console.WriteLine(cow7.name + ":" + ((0.5* 40000) - (cow7.foodvolume * 10000)));
    Console.WriteLine(cow8.name + ":" + (((cow8.weight - cow8.fatweight) * 480000) - (cow8.foodvolume * 10000)));
    Console.WriteLine(cow9.name + ":" + (((cow9.weight - cow9.fatweight) * 200000) - (cow9.foodvolume * 10000)));
    Console.WriteLine(cow10.name + ":" + ((2.5*80000) - (cow10.foodvolume * 10000)));
}

if (x ==7)
{
    Console.WriteLine(cow1.name+":"+((((cow1.maximumage-cow1.age)*365)*cow1.foodvolume)*10000));
    Console.WriteLine(cow2.name + ":" + ((((cow2.maximumage - cow2.age) * 365) * cow2.foodvolume) * 10000));
    Console.WriteLine(cow3.name + ":" + ((((cow3.maximumage - cow3.age) * 365) * cow3.foodvolume) * 10000));
    Console.WriteLine(cow4.name + ":" + ((((cow4.maximumage - cow4.age) * 365) * cow4.foodvolume) * 10000));
    Console.WriteLine(cow5.name + ":" + ((((cow5.maximumage - cow5.age) * 365) * cow5.foodvolume) * 10000));
    Console.WriteLine(cow6.name + ":" + ((((cow6.maximumage - cow6.age) * 365) * cow6.foodvolume) * 10000));
    Console.WriteLine(cow7.name + ":" + ((((cow7.maximumage - cow7.age) * 365) * cow7.foodvolume) * 10000));
    Console.WriteLine(cow8.name + ":" + ((((cow8.maximumage - cow8.age) * 365) * cow8.foodvolume) * 10000));
    Console.WriteLine(cow9.name + ":" + ((((cow9.maximumage - cow9.age) * 365) * cow9.foodvolume) * 10000));
    Console.WriteLine(cow10.name + ":" + ((((cow10.maximumage - cow10.age) * 365) * cow10.foodvolume) * 10000));


}
if (x == 8)
{
    Console.WriteLine("sood chand sal ayande ra mikhahid???");
    int y = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(cow2.name+":"+(40000-(cow2.foodvolume*10000))*(y*365));

    Console.WriteLine(cow3.name + ":" + (40000 - (cow3.foodvolume * 10000)) * (y * 365));
    Console.WriteLine(cow4.name + ":" + (1.75*80000 - (cow4.foodvolume * 10000)) * (y * 365));
    Console.WriteLine(cow6.name + ":" + (2*80000 - (cow6.foodvolume * 10000)) * (y * 365));
    Console.WriteLine(cow7.name + ":" + (0.5*40000 - (cow7.foodvolume * 10000)) * (y * 365));
    Console.WriteLine(cow10.name + ":" + (2.5*80000 - (cow10.foodvolume * 10000)) * (y * 365));

}

class Animal
{
    public string name { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public double maximumage { get; set; }
    public double age { get; set; }
    public double weight { get; set; }
    public double fatweight { get; set; }
    public double dailystool { get; set; }
    public string typeoffood { get; set; }
    public double foodvolume { get; set; }
    public string patient { get; set; }
    public string skin { get; set; }


     public List<Product> products { get; set; }





    
}
class Product
{

    public string name { get; set; }
    public string unit { get; set; }
    public double price { get; set; }
    public double dailyamount { get; set; }

  


}




















