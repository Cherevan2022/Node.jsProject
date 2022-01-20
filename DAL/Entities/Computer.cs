using System;

namespace DAL.Entities
{
    public class Computer
    {
        /// <summary>
        /// уникальный айди
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// картинка
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// описание
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// модель
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// процессор
        /// </summary>
        public virtual CPU CPU { get; set; }
        /// <summary>
        /// оперативная память
        /// </summary>
        public virtual RAM RAM { get; set; }
        /// <summary>
        /// видеокарта
        /// </summary>
        public virtual GPU GPU { get; set; }
        /// <summary>
        /// фирма-производитель
        /// </summary>
        public string Producer { get; set; }
    }
}