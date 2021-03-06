using System;
class Creature
{
    protected string Name;
    protected int Hp;
    public Creature(string name){
        Hp = 100;
        Name = name;
    }
    // 封裝性
    public int HP
    {
        get{ return Hp; }
        set{ 
                if(value >= Hp){
                    Hp = 0;
                }else{
                    Hp -= value;
                }
            }
    }
    public virtual void talk(){
        Console.WriteLine("my name is : " + Name);    
    }
    public void injured(int dmg){
        Hp -= dmg;    
    }
}