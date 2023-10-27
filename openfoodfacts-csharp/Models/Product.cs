
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace OpenFoodFactsCSharp.model
{
    public class Product
    {
        [JsonProperty("languages_codes")]
        public LanguagesCodes? LanguagesCodes { get; set; }
        [JsonProperty("nutrient_levels")]
        public NutrientLevels? NutrientLevels { get; set; }
        [JsonProperty("selected_images")]
        public SelectedImages? SelectedImages { get; set; }
        [JsonProperty("additives_n")]
        public int? AdditivesN { get; set; }
        [JsonProperty("additives_old_n")]
        public int? AdditivesOldN { get; set; }
        [JsonProperty("additives_original_tags")]
        public String[]? AdditivesOriginalTags { get; set; }
        [JsonProperty("additives_old_tags")]
        public String[]? AdditivesOldTags { get; set; }
        [JsonProperty("additives_prev_original_tags")]
        public String[]? AdditivesPrevOriginalTags { get; set; }
        [JsonProperty("additives_debug_tags")]
        public String[]? AdditivesDebugTags { get; set; }
        [JsonProperty("additives_tags")]
        public String[]? AdditivesTags { get; set; }
        [JsonProperty("allergens_from_ingredients")]
        public string? AllergensFromIngredients { get; set; }
        [JsonProperty("allergens_from_user")]
        public string? AllergensFromUser { get; set; }
        [JsonProperty("allergens_hierarchy")]
        public String[]? AllergensHierarchy { get; set; }
        [JsonProperty("allergens_lc")]
        public string? AllergensLc { get; set; }
        [JsonProperty("allergens_tags")]
        public String[]? AllergensTags { get; set; }
        [JsonProperty("amino_acids_prev_tags")]
        public String[]? AminoAcidsPrevTags { get; set; }
        [JsonProperty("amino_acids_tags")]
        public String[]? AminoAcidsTags { get; set; }
        public String? Brands { get;set; }
        [JsonProperty("brands_debug_tags")]
        public String[]? BrandsDebugTags { get; set; }
        [JsonProperty("brands_tags")]
        public String[]? BrandsTags { get; set; }
        [JsonProperty("carbon_footprint_percent_of_known_ingredients")]
        public string? CarbonFootprintPercentOfKnownIngredients { get; set; }
        [JsonProperty("carbon_footprint_from_known_ingredients_debug")]
        public string? CarbonFootprintFromKnownIngredientsDebug { get; set; }
        [JsonProperty("categories_hierarchy")]
        public String[]? CategoriesHierarchy { get; set; }
        [JsonProperty("categories_lc")]
        public string? CategoriesLc { get; set; }
        [JsonProperty("categories_properties_tags")]
        public String[]? CategoriesPropertiesTags { get; set; }
        [JsonProperty("categories_tags")]
        public String[]? CategoriesTags { get; set; }
        [JsonProperty("checkers_tags")]
        public String[]? CheckersTags { get; set; }
        [JsonProperty("cities_tags")]
        public String[]? CitiesTags { get; set; }
        [JsonProperty("codes_tags")]
        public String[]? CodesTags { get; set; }
        [JsonProperty("compared_to_category")]
        public string? ComparedToCategory { get; set; }
        [JsonProperty("completed_t")]
        public long? CompletedT { get; set; }
        [JsonProperty("conservation_conditions")]
        public string? ConservationConditions { get; set; }
        [JsonProperty("countries_hierarchy")]
        public String[]? CountriesHierarchy { get; set; }
        [JsonProperty("countries_lc")]
        public string? CountriesLc { get; set; }
        [JsonProperty("countries_debug_tags")]
        public String[]? CountriesDebugTags { get; set; }
        [JsonProperty("countries_tags")]
        public String[]? CountriesTags { get; set; }
        [JsonProperty("correctors_tags")]
        public String[]? CorrectorsTags { get; set; }
        [JsonProperty("created_t")]
        public long? CreatedT { get; set; }
        [JsonProperty("data_quality_bugs_tags")]
        public String[]? DataQualityBugsTags { get; set; }
        [JsonProperty("data_quality_errors_tags")]
        public String[]? DataQualityErrorsTags { get; set; }
        [JsonProperty("data_quality_info_tags")]
        public String[]? DataQualityInfoTags { get; set; }
        [JsonProperty("data_quality_tags")]
        public String[]? DataQualityTags { get; set; }
        [JsonProperty("data_quality_warnings_tags")]
        public String[]? DataQualityWarningsTags { get; set; }
        [JsonProperty("data_sources")]
        public string? DataSources { get; set; }
        [JsonProperty("data_sources_tags")]
        public String[]? DataSourcesTags { get; set; }
        [JsonProperty("debug_param_sorted_langs")]
        public String[]? DebugParamSortedLangs { get; set; }
        [JsonProperty("editors_tags")]
        public String[]? EditorsTags { get; set; }
        [JsonProperty("emb_codes")]
        public string? EmbCodes { get; set; }
        [JsonProperty("emb_codes_debug_tags")]
        public String[]? EmbCodesDebugTags { get; set; }
        [JsonProperty("emb_codes_orig")]
        public string? EmbCodesOrig { get; set; }
        [JsonProperty("emb_codes_tags")]
        public String[]? EmbCodesTags { get; set; }
        [JsonProperty("entry_dates_tags")]
        public String[]? EntryDatesTags { get; set; }
        [JsonProperty("expiration_date")]
        public string? ExpirationDate { get; set; }
        [JsonProperty("expiration_date_debug_tags")]
        public String[]? ExpirationDateDebugTags { get; set; }
        [JsonProperty("fruits-vegetables-nuts_100g_estimate")]
        public int? FruitsVegetablesNuts100GEstimate { get; set; }
        [JsonProperty("generic_name")]
        public string? GenericName { get; set; }
        [JsonProperty("image_front_small_url")]
        public string? ImageFrontSmallUrl { get; set; }
        [JsonProperty("image_front_thumb_url")]
        public string? ImageFrontThumbUrl { get; set; }
        [JsonProperty("image_front_url")]
        public string? ImageFrontUrl { get; set; }
        [JsonProperty("image_ingredients_url")]
        public string? ImageIngredientsUrl { get; set; }
        [JsonProperty("image_ingredients_small_url")]
        public string? ImageIngredientsSmallUrl { get; set; }
        [JsonProperty("image_ingredients_thumb_url")]
        public string? ImageIngredientsThumbUrl { get; set; }
        [JsonProperty("image_nutrition_small_url")]
        public string? ImageNutritionSmallUrl { get; set; }
        [JsonProperty("image_nutrition_thumb_url")]
        public string? ImageNutritionThumbUrl { get; set; }
        [JsonProperty("image_nutrition_url")]
        public string? ImageNutritionUrl { get; set; }
        [JsonProperty("image_small_url")]
        public string? ImageSmallUrl { get; set; }
        [JsonProperty("image_thumb_url")]
        public string? ImageThumbUrl { get; set; }
        [JsonProperty("image_url")]
        public string? ImageUrl { get; set; }
        [JsonProperty("informers_tags")]
        public String[]? InformersTags { get; set; }
        [JsonProperty("ingredients_analysis_tags")]
        public String[]? IngredientsAnalysisTags { get; set; }
        [JsonProperty("ingredients_debug")]
        public String[]? IngredientsDebug { get; set; }
        [JsonProperty("ingredients_from_or_that_may_be_from_palm_oil_n")]
        public int? IngredientsFromOrThatMayBeFromPalmOilN { get; set; }
        [JsonProperty("ingredients_from_palm_oil_tags")]
        public String[]? IngredientsFromPalmOilTags { get; set; }
        [JsonProperty("ingredients_from_palm_oil_n")]
        public int? IngredientsFromPalmOilN { get; set; }
        [JsonProperty("ingredients_hierarchy")]
        public String[]? IngredientsHierarchy { get; set; }
        [JsonProperty("ingredients_ids_debug")]
        public String[]? IngredientsIdsDebug { get; set; }
        [JsonProperty("ingredients_n")]
        public int? IngredientsN { get; set; }
        [JsonProperty("ingredients_n_tags")]
        public String[]? IngredientsNTags { get; set; }
        [JsonProperty("ingredients_original_tags")]
        public String[]? IngredientsOriginalTags { get; set; }
        [JsonProperty("ingredients_tags")]
        public String[]? IngredientsTags { get; set; }
        [JsonProperty("ingredients_text")]
        public string? IngredientsText { get; set; }
        [JsonProperty("ingredients_text_debug")]
        public string? IngredientsTextDebug { get; set; }
        [JsonProperty("ingredients_text_with_allergens")]
        public string? IngredientsTextWithAllergens { get; set; }
        [JsonProperty("ingredients_that_may_be_from_palm_oil_n")]
        public int? IngredientsThatMayBeFromPalmOilN { get; set; }
        [JsonProperty("ingredients_that_may_be_from_palm_oil_tags")]
        public String[]? IngredientsThatMayBeFromPalmOilTags { get; set; }
        [JsonProperty("interface_version_created")]
        public string? InterfaceVersionCreated { get; set; }
        [JsonProperty("interface_version_modified")]
        public string? InterfaceVersionModified { get; set; }
        [JsonProperty("_keywords")]
        public String[]? Keywords { get; set; }
        [JsonProperty("known_ingredients_n")]
        public int? KnownIngredientsN { get; set; }
        [JsonProperty("labels_hierarchy")]
        public String[]? LabelsHierarchy { get; set; }
        [JsonProperty("labels_lc")]
        public string? LabelsLc { get; set; }
        [JsonProperty("labels_prev_hierarchy")]
        public String[]? LabelsPrevHierarchy { get; set; }
        [JsonProperty("labels_prev_tags")]
        public String[]? LabelsPrevTags { get; set; }
        [JsonProperty("labels_tags")]
        public String[]? LabelsTags { get; set; }
        [JsonProperty("labels_debug_tags")]
        public String[]? LabelsDebugTags { get; set; }
        [JsonProperty("lang_debug_tags")]
        public String[]? LangDebugTags { get; set; }
        [JsonProperty("languages_hierarchy")]
        public String[]? LanguagesHierarchy { get; set; }
        [JsonProperty("languages_tags")]
        public String[]? LanguagesTags { get; set; }
        [JsonProperty("last_edit_dates_tags")]
        public String[]? LastEditDatesTags { get; set; }
        [JsonProperty("last_editor")]
        public string? LastEditor { get; set; }
        [JsonProperty("last_image_dates_tags")]
        public String[]? LastImageDatesTags { get; set; }
        [JsonProperty("last_image_t")]
        public long? LastImageT { get; set; }
        [JsonProperty("last_modified_by")]
        public string? LastModifiedBy { get; set; }
        [JsonProperty("last_modified_t")]
        public long? LastModifiedT { get; set; }
        [JsonProperty("link_debug_tags")]
        public String[]? LinkDebugTags { get; set; }
        [JsonProperty("manufacturing_places")]
        public string? ManufacturingPlaces { get; set; }
        [JsonProperty("manufacturing_places_debug_tags")]
        public String[]? ManufacturingPlacesDebugTags { get; set; }
        [JsonProperty("manufacturing_places_tags")]
        public String[]? ManufacturingPlacesTags { get; set; }
        [JsonProperty("max_imgid")]
        public string? MaxImgid { get; set; }
        [JsonProperty("minerals_prev_tags")]
        public String[]? MineralsPrevTags { get; set; }
        [JsonProperty("minerals_tags")]
        public String[]? MineralsTags { get; set; }
        [JsonProperty("misc_tags")]
        public String[]? MiscTags { get; set; }
        [JsonProperty("net_weight_unit")]
        public string? NetWeightUnit { get; set; }
        [JsonProperty("net_weight_value")]
        public string? NetWeightValue { get; set; }
        [JsonProperty("nutrition_data_per")]
        public string? NutritionDataPer { get; set; }
        [JsonProperty("nutrition_score_warning_no_fruits_vegetables_nuts")]
        public int? NutritionScoreWarningNoFruitsVegetablesNuts { get; set; }
        [JsonProperty("no_nutrition_data")]
        public string? NoNutritionData { get; set; }
        [JsonProperty("nova_group")]
        public string? NovaGroup { get; set; }
        [JsonProperty("nova_groups")]
        public string? NovaGroups { get; set; }
        [JsonProperty("nova_group_debug")]
        public string? NovaGroupDebug { get; set; }
        [JsonProperty("nova_group_tags")]
        public String[]? NovaGroupTags { get; set; }
        [JsonProperty("nova_groups_tags")]
        public String[]? NovaGroupsTags { get; set; }
        [JsonProperty("nucleotides_prev_tags")]
        public String[]? NucleotidesPrevTags { get; set; }
        [JsonProperty("nucleotides_tags")]
        public String[]? NucleotidesTags { get; set; }
        [JsonProperty("nutrient_levels_tags")]
        public String[]? NutrientLevelsTags { get; set; }
        [JsonProperty("nutrition_data")]
        public string? NutritionData { get; set; }
        [JsonProperty("nutrition_data_per_debug_tags")]
        public String[]? NutritionDataPerDebugTags { get; set; }
        [JsonProperty("nutrition_data_prepared")]
        public string? NutritionDataPrepared { get; set; }
        [JsonProperty("nutrition_data_prepared_per")]
        public string? NutritionDataPreparedPer { get; set; }
        [JsonProperty("nutrition_grades")]
        public string? NutritionGrades { get; set; }
        [JsonProperty("nutrition_score_beverage")]
        public int? NutritionScoreBeverage { get; set; }
        [JsonProperty("nutrition_score_debug")]
        public string? NutritionScoreDebug { get; set; }
        [JsonProperty("nutrition_score_warning_no_fiber")]
        public int? NutritionScoreWarningNoFiber { get; set; }
        [JsonProperty("nutrition_grades_tags")]
        public String[]? NutritionGradesTags { get; set; }
        [JsonProperty("origins_debug_tags")]
        public String[]? OriginsDebugTags { get; set; }
        [JsonProperty("origins_tags")]
        public String[]? OriginsTags { get; set; }
        [JsonProperty("other_information")]
        public string? OtherInformation { get; set; }
        [JsonProperty("other_nutritional_substances_tags")]
        public String[]? OtherNutritionalSubstancesTags { get; set; }
        [JsonProperty("packaging_debug_tags")]
        public String[]? PackagingDebugTags { get; set; }
        [JsonProperty("packaging_tags")]
        public String[]? PackagingTags { get; set; }
        [JsonProperty("photographers_tags")]
        public String[]? PhotographersTags { get; set; }
        [JsonProperty("pnns_groups_1")]
        public string? PnnsGroups1 { get; set; }
        [JsonProperty("pnns_groups_2")]
        public string? PnnsGroups2 { get; set; }
        [JsonProperty("pnns_groups_1_tags")]
        public String[]? PnnsGroups1Tags { get; set; }
        [JsonProperty("pnns_groups_2_tags")]
        public String[]? PnnsGroups2Tags { get; set; }
        [JsonProperty("popularity_key")]
        public long? PopularityKey { get; set; }
        [JsonProperty("producer_version_id")]
        public string? ProducerVersionId { get; set; }
        [JsonProperty("product_name")]
        public string? ProductName { get; set; }
        [JsonProperty("product_quantity")]
        public string? ProductQuantity { get; set; }
        [JsonProperty("purchase_places")]
        public string? PurchasePlaces { get; set; }
        [JsonProperty("purchase_places_debug_tags")]
        public String[]? PurchasePlacesDebugTags { get; set; }
        [JsonProperty("purchase_places_tags")]
        public String[]? PurchasePlacesTags { get; set; }
        [JsonProperty("quality_tags")]
        public String[]? QualityTags { get; set; }
        [JsonProperty("quantity_debug_tags")]
        public String[]? QuantityDebugTags { get; set; }
        [JsonProperty("recycling_instructions_to_discard")]
        public string? RecyclingInstructionsToDiscard { get; set; }
        [JsonProperty("serving_quantity")]
        public string? ServingQuantity { get; set; }
        [JsonProperty("serving_size")]
        public string? ServingSize { get; set; }
        [JsonProperty("serving_size_debug_tags")]
        public String[]? ServingSizeDebugTags { get; set; }
        [JsonProperty("states_hierarchy")]
        public String[]? StatesHierarchy { get; set; }
        [JsonProperty("states_tags")]
        public String[]? StatesTags { get; set; }
        [JsonProperty("stores_debug_tags")]
        public String[]? StoresDebugTags { get; set; }
        [JsonProperty("stores_tags")]
        public String[]? StoresTags { get; set; }
        [JsonProperty("traces_from_ingredients")]
        public string? TracesFromIngredients { get; set; }
        [JsonProperty("traces_hierarchy")]
        public String[]? TracesHierarchy { get; set; }
        [JsonProperty("traces_debug_tags")]
        public String[]? TracesDebugTags { get; set; }
        [JsonProperty("traces_from_user")]
        public string? TracesFromUser { get; set; }
        [JsonProperty("traces_lc")]
        public string? TracesLc { get; set; }
        [JsonProperty("traces_tags")]
        public String[]? TracesTags { get; set; }
        [JsonProperty("unknown_ingredients_n")]
        public int? UnknownIngredientsN { get; set; }
        [JsonProperty("unknown_nutrients_tags")]
        public String[]? UnknownNutrientsTags { get; set; }
        [JsonProperty("update_key")]
        public string? UpdateKey { get; set; }
        [JsonProperty("vitamins_prev_tags")]
        public String[]? VitaminsPrevTags { get; set; }
        [JsonProperty("vitamins_tags")]
        public String[]? VitaminsTags { get; set; }
    }
}
