﻿namespace Mmu.Ngs.WebApi.Areas.Individuals.Dtos
{
    public class AddressDto
    {
        public AddressTypeDto AddressType { get; set; }
        public string City { get; set; }
        public string Id { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
    }
}
