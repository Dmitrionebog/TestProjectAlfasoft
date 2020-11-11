using System.Collections.Generic;

namespace Graph
{

    public class Node
    {
        public List<Node> Childs;
        public string value;
        public Node(string val)
        {
            Childs = new List<Node>();
            value = val;
        }

        public void AddChild( Node childNode)
        {
            Childs.Add(childNode);
        }
        public void AddChilds(List<Node> childNodes) 
        {
            foreach (Node child in childNodes)
            {
                Childs.Add(child);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node orange = new Node("Оранжевый");
            Node yellow = new Node("Желтый");
            Node lightblue = new Node("Голубой");
            Node blue = new Node("Синий");
            Node red = new Node("Красный");
            Node purple = new Node("Фиолетовый");
            Node green = new Node("Зеленый");

            List<Node> childsOfBlue = new List<Node>();
            childsOfBlue.Add(orange);
            childsOfBlue.Add(yellow);
            blue.AddChilds(childsOfBlue);

            List<Node> childsOfPurple = new List<Node>();
            childsOfPurple.Add(lightblue);
            purple.AddChilds(childsOfPurple);

            List<Node> childsOfGreen = new List<Node>();
            childsOfGreen.Add(blue);
            childsOfGreen.Add(red);
            childsOfGreen.Add(purple);
            green.AddChilds(childsOfGreen);
        }
    }
}

