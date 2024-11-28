
﻿using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class PersonalInfo
    {
        [Required(ErrorMessage = "Veuillez indiquer votre nom")]
        public string Name { get; set; }

        // Propriété pour le prénom
        [Required(ErrorMessage = "Veuillez indiquer votre prénom")]
        public string Forename { get; set; }

        // Propriété pour le genre, avec une valeur par défaut
        [Required(ErrorMessage = "Veuillez sélectionner un genre.")]
        public string Gender { get; set; } = "Select a gender";

        // Propriété pour l'adresse
        [Required(ErrorMessage = "Veuillez indiquer votre adresse")]
        public string Address { get; set; }

        // Propriété pour le code postal avec contrôle de format
        [Required(ErrorMessage = "Veuillez indiquer votre code postal")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Le code postal doit contenir exactement 5 chiffres.")]
        public string ZipCode { get; set; }

        // Propriété pour la ville
        [Required(ErrorMessage = "Veuillez indiquer votre ville")]
        public string Town { get; set; }

        // Propriété pour l'adresse email avec contrôle de format
        [Required(ErrorMessage = "Veuillez indiquer votre adresse mail")]
        [RegularExpression(@"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "Format d'adresse email invalide.")]
        public string Email { get; set; }

        // Propriété pour la date de début de la formation avec contrôle
        [Required(ErrorMessage = "Veuillez indiquer le début de votre formation")]
        [DataType(DataType.Date, ErrorMessage = "Format de date invalide.")]
        [Range(typeof(DateTime), "01/01/1900", "31/12/2020", ErrorMessage = "La date doit être antérieure au 01/01/2021.")]
        public DateTime StartDate { get; set; }

        // Propriété pour le type de formation
        [Required(ErrorMessage = "Veuillez sélectionner un type de formation.")]
        public string TrainingType { get; set; } = "Select a course";

        // Avis sur la formation 
        [Required(ErrorMessage = "Veuillez entrer un avis sur la formation.")]
        [StringLength(500, ErrorMessage = "L'avis ne peut pas dépasser 500 caractères.")]
        public string Review { get; set; }

        // Objectif de la formation
        [Required(ErrorMessage = "Veuillez indiquer l'objectif de la formation.")]
        [StringLength(500, ErrorMessage = "L'objectif ne peut pas dépasser 500 caractères.")]
        public string TrainingPurpose { get; set; }
    }
}

