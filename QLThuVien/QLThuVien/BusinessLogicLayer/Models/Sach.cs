// File: Models/SachModel.cs
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLogicLayer.Models
{
    public class SachModel : Publisher
    {
        private DataTable result;
        private List<Sach> sachList;

        public SachModel()
        {
            sachList = new List<Sach>();
        }

        public void AddSach(Sach sach)
        {
            sachList.Add(sach);
            ChangeState();
        }

        public void DeleteSach(string maSach)
        {
            sachList.RemoveAll(s => s.MaSach == maSach);
            ChangeState();
        }

        public void UpdateSach(Sach updatedSach)
        {
            for (int i = 0; i < sachList.Count; i++)
            {
                if (sachList[i].MaSach == updatedSach.MaSach)
                {
                    sachList[i] = updatedSach;
                    break;
                }
            }
            ChangeState();
        }

        public DataTable SearchSach(string query)
        {
            // Implement search logic here
            // For now, just return an empty DataTable
            result = new DataTable();
            ChangeState();
            return result;
        }

        public DataTable GetResult()
        {
            return result;
        }

        private void ChangeState()
        {
            Notify();
        }
    }
}