using System;

namespace DAL.Entities
{
    /// <summary>
    /// оперативная память
    /// </summary>
    public class RAM
    {
        /// <summary>
        /// уникальный айди
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// поколение
        /// </summary>
        public string Generation { get; set; }
        /// <summary>
        /// размер памяти
        /// </summary>
        public int Size { get; set; }
    }
}