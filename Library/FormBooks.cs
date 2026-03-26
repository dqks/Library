using Library.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class FormBooks : Form
    {
        public bool IsGuest { get; private set; }
        public User User { get; private set; }
        
        public FormBooks(bool isGuest, User user)
        {
            InitializeComponent();

            this.IsGuest = isGuest;
            this.User = user;
        }


    }
}
