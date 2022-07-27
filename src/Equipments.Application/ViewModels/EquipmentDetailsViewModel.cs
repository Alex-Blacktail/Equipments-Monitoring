using System;
using AutoMapper;
using Equipments.Application.Common.Mappings;
using Equipments.Domain;

namespace Equipments.Application.ViewModels
{
    public class EquipmentDetailsViewModel : IMapWith<Equipment>
    {
        /// <summary>
        /// Тип оргтехники
        /// </summary>
        public string EquipmentType { get; set; }

        /// <summary>
        /// Наименование оргтехники
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Модель (номер модели)
        /// </summary>
        public string ModelNumber { get; set; }

        /// <summary>
        /// Инвентарный номер
        /// </summary>
        public string InventoryNumber { get; set; }

        /// <summary>
        /// Дата производства
        /// </summary>
        public DateTime ProductionDate { get; set; }

        /// <summary>
        /// Дата получения
        /// </summary>
        public DateTime ReceiptDate { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Equipment, EquipmentDetailsViewModel>()
                .ForMember(vm => vm.Name, e => e.MapFrom(e => e.Name))
                .ForMember(vm => vm.EquipmentType, e => e.MapFrom(e => e.EquipmentType.Name))
                .ForMember(vm => vm.ModelNumber, e => e.MapFrom(e => e.ModelNumber))
                .ForMember(vm => vm.InventoryNumber, e => e.MapFrom(e => e.InventoryNumber))
                .ForMember(vm => vm.ProductionDate, e => e.MapFrom(e => e.ProductionDate))
                .ForMember(vm => vm.ReceiptDate, e => e.MapFrom(e => e.ReceiptDate));
        }
    }
}
