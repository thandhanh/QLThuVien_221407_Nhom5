// File: PresentationLayer/Views/SachView.cs
using System;
using System.Windows.Forms;

namespace PresentationLayer.Views
{
    public abstract class SachView : Form, ISubscriber
    {
        protected Sach model;
        protected SachController controller;

        public SachView(Sach model, SachController controller)
        {
            this.model = model;
            this.controller = controller;
            model.Subscribe(this);
        }

        protected abstract void LoadData();
        protected abstract void ClearAll();

        public void Update()
        {
            LoadData();
        }
    }
}