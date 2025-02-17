using System.ComponentModel;
using lab4.Context;
using lab4.Entity;
using System.Collections.Generic;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;


namespace lab4;

public partial class Form1 : Form
{
    private DefaultContext? dbContext;

    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        this.dbContext = new DefaultContext();

        this.dbContext.Visitors.Load();

        this.visitorBindingSource.DataSource = dbContext.Visitors.Local.ToBindingList();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        this.dbContext?.Dispose();

        this.dbContext = null;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        VisitorForm visitorForm = new VisitorForm();

        List<Room> rooms = dbContext.Rooms.ToList();

        visitorForm.listBox1.DataSource = rooms;
        visitorForm.listBox1.ValueMember = "Id";
        visitorForm.listBox1.DisplayMember = "Number";

        DialogResult result = visitorForm.ShowDialog(this);

        if (result == DialogResult.Cancel)
        {
            return;
        }

        Visitor visitor = new Visitor();

        visitor.Name = visitorForm.VisitorName.Text.Trim();
        visitor.Phone = visitorForm.VisitorPhone.Text.Trim();
        visitor.Age = (int)visitorForm.VisitorAge.Value;

        rooms.Clear();

        foreach (var item in visitorForm.listBox1.SelectedItems)
        {
            rooms.Add((Room)item);
        }

        visitor.Room = rooms.FirstOrDefault();

        dbContext.Visitors.Add(visitor);

        dbContext.SaveChanges();

        MessageBox.Show("Новый посетитель добавлен");
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count < 1)
        {
            return;
        }

        int index = dataGridView1.SelectedRows[0].Index;
        int id = 0;

        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

        if (converted == false)
        {
            return;
        }

        Visitor visitor = dbContext.Visitors.Find(id);
        VisitorForm visitorForm = new VisitorForm();

        visitorForm.VisitorName.Text = visitor.Name;
        visitorForm.VisitorPhone.Text = visitor.Phone;
        visitorForm.VisitorAge.Value = visitor.Age;

        List<Room> rooms = dbContext.Rooms.ToList();

        // заполняем список всеми командами

        visitorForm.listBox1.DataSource = rooms;
        visitorForm.listBox1.ValueMember = "Id";
        visitorForm.listBox1.DisplayMember = "Number";

        DialogResult result = visitorForm.ShowDialog(this);

        if (result == DialogResult.Cancel)
        {
            return;
        }

        visitor.Name = visitorForm.VisitorName.Text.Trim();
        visitor.Phone = visitorForm.VisitorPhone.Text.Trim();
        visitor.Age = (int)visitorForm.VisitorAge.Value;

        rooms.Clear();

        foreach (var item in visitorForm.listBox1.SelectedItems)
        {
            rooms.Add((Room)item);
        }
        visitor.Room = rooms.FirstOrDefault();

        dbContext.Entry(visitor).State = EntityState.Modified;
        dbContext.SaveChanges();

        MessageBox.Show("Информация обновлена");

        dataGridView1.Refresh();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (dataGridView1.SelectedRows.Count < 1)
        {
            return;
        }

        int index = dataGridView1.SelectedRows[0].Index;
        int id = 0;

        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);

        if (converted == false)
        {
            return;
        }

        Visitor visitor = dbContext.Visitors.Find(id);

        dbContext.Visitors.Remove(visitor);

        dbContext.SaveChanges();

        MessageBox.Show("Посетитель удален");
    }

    private void button4_Click(object sender, EventArgs e)
    {
        RoomForm roomForm = new RoomForm();

        DialogResult result = roomForm.ShowDialog(this);
        if (result == DialogResult.Cancel)
        {
            return;
        }

        Room room = new Room();

        room.Number = roomForm.RoomNumber.Text;
        room.Floor = roomForm.RoomFloor.Text;
        room.Price = (int)roomForm.RoomPrice.Value;

        dbContext.Rooms.Add(room);

        dbContext.SaveChanges();
        
        MessageBox.Show("Новые апартаменты добавлены");
    }
}