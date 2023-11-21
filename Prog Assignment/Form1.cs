namespace Prog_Assignment
{
    public partial class Form1 : Form
    {
        string path = "stock.txt";// the path to the text file is created 
        List<Stock> list;// creates the list
        User user1;//declaring the users
        User user2;

        public Form1()
        {
            InitializeComponent();
            list = new List<Stock>();//initialising the list
            string[] contents = File.ReadAllLines(path);// The file is being called here 
            foreach (string line in contents)
            {
                itemList.Items.Add(line);// this line of code helps with adding data that is inputted into the text file
                list.Add(new Stock(line));// adds contents of thew file into stocklist
                //create an item class
            }
            //itemList.Text = contents.ToString();
            //itemList.Text = string.Join("\n", contents);
            //itemList.Items. = contents;

            user1= new User("Manager","test");
            user2 = new User("Employee", "test2");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Stock_1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string newItems = ItemBox.Text;// the string for newitems ins defined 
            string numbItems = NumbBox.Text;// string for numbitems is defined 
            string formattedText = ItemBox.Text + " X " + numbItems + "\n"; // this line of code acts as a backend for the format of the text file
            itemList.Items.Add(newItems  + " X " + numbItems);// adds an item along with the amount into the file
            list.Add(new Stock(newItems  + " X " + numbItems));// adds to stocklist


            File.AppendAllText(path, formattedText);// adds data onto the text file whilst also not deleting it.

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //StockList Items = new StockList();
            string currentlySelected = itemList.SelectedItems[0].ToString();//grabs the selected into a string and stores it into the currentlyselected
            itemList.Items.Remove(currentlySelected);//removes the selected from the item list box
            string[] tempContents = File.ReadAllLines(path);//
            // string[] temp = new string[tempContents.Length];
            List<string> temp = new List<string>();

            foreach(string line in tempContents)// this entire thing adds all the items apart from the currentlyselected into the file
            {
                if (!line.Equals(currentlySelected))
                {
                    temp.Add(line);
                }
             
            }
            File.WriteAllLines(path,temp);

            list.Clear();
            string[] contents = File.ReadAllLines(path);// same as above but for stocklist
            foreach (string line in contents)
            {
                list.Add(new Stock(line));
                //create an item class from new
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {// This looks at the locally stored data which has been grabbed rfrom the file and then searches and adds whatever items match what is being searched for
            CheckList.Items.Clear();
            if (!string.IsNullOrEmpty(CheckBox.Text))
            {
                foreach (Stock stockItem in list)
                {
                    if (stockItem.item.Contains(CheckBox.Text))//checks that items contain the searched item
                    {
                        CheckList.Items.Add(stockItem.item);// adds the matching items
                    }
                }
            }
            else
            {
                foreach (Stock stockItem in list)
                {
                    CheckList.Items.Add(stockItem.item);// adds all the items 
                }
            }
        }

        private void StockList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ItemBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumbBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            //if statement to hide or show the stuff on the side
            if (textUser.Text == user1.getUsername())
            {
                if (user1.checkPassword(textPass.Text))
                {
                    ItemBox.Visible = true;
                    NumbBox.Visible = true;
                    Item.Visible = true;
                    Amount.Visible = true;
                    AddButton.Visible = true;
                    RemoveButton.Visible = true;
                    itemList.Visible = true;
                    label1.Visible = true;
                    CheckBox.Visible = true;
                    LabelCheck.Visible = true;
                    CheckList.Visible = true;   

                }

            }
            else if (textUser.Text == user2.getUsername())
            {
                if (user2.checkPassword(textPass.Text))
                {
                    CheckBox.Visible = true;
                    LabelCheck.Visible = true;
                    CheckList.Visible = true;

                }
            }
        }
        //class User

    }
}