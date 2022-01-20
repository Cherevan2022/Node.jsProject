using System;

namespace DAL.Entities
{
    /// <summary>
    /// процессор
    /// </summary>
    public class CPU
    {
        /// <summary>
        /// уникальный айди
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// марка процессора
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// кол-во ядер
        /// </summary>
        public int CoresCount { get; set; }
    }
}