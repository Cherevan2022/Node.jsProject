using System;

namespace DAL.Entities
{
    /// <summary>
    /// видеокарта
    /// </summary>
    public class GPU
    {
        /// <summary>
        /// уникальный айди
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// марка
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// размер
        /// </summary>
        public int Size { get; set; }
    }
}