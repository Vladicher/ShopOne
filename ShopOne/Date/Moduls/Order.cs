using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ShopOne.Date.Moduls
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }
        
        [Display(Name = "Введите имя")]
        [StringLength(10)]
        [Required(ErrorMessage = "Длина имени не менее 3-х символов ")]
        public string Name { get; set; }
        
        
        [Display(Name = "Введите Фамилию")]
        [StringLength(12)]
        [Required(ErrorMessage = "Длина фамилии не менее 3-х символов ")]
        public string SurName { get; set; }
        
        [Display(Name = "Введите номер телефона")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Длина номера не менее 5-х символов ")]
        public string Phone { get; set; }

        [Display(Name = "Введите email")]
        [StringLength(20)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Длина email не менее 10-х символов ")]
        public string Email { get; set; }


        [Display(Name = "Введите адрес")]
        [StringLength(35)]
        [Required(ErrorMessage = "Длина адреса не менее 15-х символов ")]
        public string Adress { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }



    }
}
