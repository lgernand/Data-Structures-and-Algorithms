using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class DynamicArray
    {

        private int[] _data;
        private uint _size;

        public DynamicArray(uint size)
        {
            this._data = new int[size];
            this._size = 0;
        }

        public void Insert(int newData)
        {
            if (_data.Length == _size)
            {
                int[] oldData = this._data;

                this._data = new int[_size * 3 / 2];

                for (int i = 0; i < this._size; ++i)
                {
                    _data[i] = oldData[i];
                }
            }

            this._data[this._size++] = newData;
        }

        public void Delete(uint index)
        {
            if (index >= this._size || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            this._data[index] = 0;

            for (uint i = index; i < this._size -1; ++i)
            {
                _data[i] = _data[i + 1];
            }

            --_size;
        }

        public int Find(int target)
        {
            for (int i = 0; i < this._size; ++i)
            {
                if (this._data[i] == target)
                { return i; }
            }

            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < this._size; ++i)
            {
                Console.Write(_data[i] + ", ");
            }
        }
    }
}
