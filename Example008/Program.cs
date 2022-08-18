int count  = 0;
int distance = 10000;
int firstFriendSpeed  = 1;
int secondFriendSpeed = 2;
int dogspeed = 5;
int friend = 2;
int time = 0;

while (distance > 10)
{ 
if (friend == 1)
{

time = distance/(firstFriendSpeed + dogspeed);

}
else 

{
   time = distance/(firstFriendSpeed + dogspeed);
   friend  = 2; 
}
distance = distance-(firstFriendSpeed+secondFriendSpeed)*time;
count = count + 1;
}
Console.WriteLine (count); 