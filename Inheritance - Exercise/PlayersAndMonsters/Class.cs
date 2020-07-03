using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Hero (string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }

    public class Elf : Hero
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Elf(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class MuseElf : Elf
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public MuseElf(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class Wizard : Hero
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Wizard(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class DarkWizard : Wizard
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public DarkWizard(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }
    public class SoulMaster : DarkWizard
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public SoulMaster(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class Knight : Hero
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public Knight(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

    public class DarkKnight : Knight
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public DarkKnight(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }
    public class BladeKnight : DarkKnight
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        public BladeKnight(string username, int level) : base(username, level)
        {
            this.Username = username;
            this.Level = level;
        }
    }

}