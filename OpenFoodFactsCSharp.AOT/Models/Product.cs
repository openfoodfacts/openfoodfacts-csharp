
using System.Text.Json.Serialization;

namespace OpenFoodFactsCSharp.AOT.Models;
public class Product
{
    [JsonPropertyName("languages_codes")]
    public LanguagesCodes LanguagesCodes { get; set; }
    
    [JsonPropertyName("nutrient_levels")]
    public NutrientLevels NutrientLevels { get; set; }
    
    [JsonPropertyName("selected_images")]
    public SelectedImages SelectedImages { get; set; }
    
    [JsonPropertyName("additives_n")]
    public int? AdditivesN { get; set; }
    
    [JsonPropertyName("additives_old_n")]
    public int? AdditivesOldN { get; set; }
    
    [JsonPropertyName("additives_original_tags")]
    public string[] AdditivesOriginalTags { get; set; }
    
    [JsonPropertyName("additives_old_tags")]
    public string[] AdditivesOldTags { get; set; }
    
    [JsonPropertyName("additives_prev_original_tags")]
    public string[] AdditivesPrevOriginalTags { get; set; }
    
    [JsonPropertyName("additives_debug_tags")]
    public string[] AdditivesDebugTags { get; set; }
    
    [JsonPropertyName("additives_tags")]
    public string[] AdditivesTags { get; set; }
    
    [JsonPropertyName("allergens_from_ingredients")]
    public string AllergensFromIngredients { get; set; }
    
    [JsonPropertyName("allergens_from_user")]
    public string AllergensFromUser { get; set; }
    
    [JsonPropertyName("allergens_hierarchy")]
    public string[] AllergensHierarchy { get; set; }
    
    [JsonPropertyName("allergens_lc")]
    public string AllergensLc { get; set; }
    
    [JsonPropertyName("allergens_tags")]
    public string[] AllergensTags { get; set; }
    
    [JsonPropertyName("amino_acids_prev_tags")]
    public string[] AminoAcidsPrevTags { get; set; }
    
    [JsonPropertyName("amino_acids_tags")]
    public string[] AminoAcidsTags { get; set; }

    // The JSON property name was absent here and was causing serialization to fail.
    [JsonPropertyName("brands")]
    public string Brands { get;set; }
    
    [JsonPropertyName("brands_debug_tags")]
    public string[] BrandsDebugTags { get; set; }
    
    [JsonPropertyName("brands_tags")]
    public string[] BrandsTags { get; set; }
    
    [JsonPropertyName("carbon_footprint_percent_of_known_ingredients")]
    public string CarbonFootprintPercentOfKnownIngredients { get; set; }
    
    [JsonPropertyName("carbon_footprint_from_known_ingredients_debug")]
    public string CarbonFootprintFromKnownIngredientsDebug { get; set; }
    
    [JsonPropertyName("categories_hierarchy")]
    public string[] CategoriesHierarchy { get; set; }
    
    [JsonPropertyName("categories_lc")]
    public string CategoriesLc { get; set; }
    
    [JsonPropertyName("categories_properties_tags")]
    public string[] CategoriesPropertiesTags { get; set; }
    
    [JsonPropertyName("categories_tags")]
    public string[] CategoriesTags { get; set; }
    
    [JsonPropertyName("checkers_tags")]
    public string[] CheckersTags { get; set; }
    
    [JsonPropertyName("cities_tags")]
    public string[] CitiesTags { get; set; }
    
    [JsonPropertyName("codes_tags")]
    public string[] CodesTags { get; set; }
    
    [JsonPropertyName("compared_to_category")]
    public string ComparedToCategory { get; set; }
    
    [JsonPropertyName("completed_t")]
    public long? CompletedT { get; set; }
    
    [JsonPropertyName("conservation_conditions")]
    public string ConservationConditions { get; set; }
    
    [JsonPropertyName("countries_hierarchy")]
    public string[] CountriesHierarchy { get; set; }
    
    [JsonPropertyName("countries_lc")]
    public string CountriesLc { get; set; }
    
    [JsonPropertyName("countries_debug_tags")]
    public string[] CountriesDebugTags { get; set; }
    
    [JsonPropertyName("countries_tags")]
    public string[] CountriesTags { get; set; }
    
    [JsonPropertyName("correctors_tags")]
    public string[] CorrectorsTags { get; set; }
    
    [JsonPropertyName("created_t")]
    public long? CreatedT { get; set; }
    
    [JsonPropertyName("data_quality_bugs_tags")]
    public string[] DataQualityBugsTags { get; set; }
    
    [JsonPropertyName("data_quality_errors_tags")]
    public string[] DataQualityErrorsTags { get; set; }
    
    [JsonPropertyName("data_quality_info_tags")]
    public string[] DataQualityInfoTags { get; set; }
    
    [JsonPropertyName("data_quality_tags")]
    public string[] DataQualityTags { get; set; }
    
    [JsonPropertyName("data_quality_warnings_tags")]
    public string[] DataQualityWarningsTags { get; set; }
    
    [JsonPropertyName("data_sources")]
    public string DataSources { get; set; }
    
    [JsonPropertyName("data_sources_tags")]
    public string[] DataSourcesTags { get; set; }
    
    [JsonPropertyName("debug_param_sorted_langs")]
    public string[] DebugParamSortedLangs { get; set; }
    
    [JsonPropertyName("editors_tags")]
    public string[] EditorsTags { get; set; }
    
    [JsonPropertyName("emb_codes")]
    public string EmbCodes { get; set; }
    
    [JsonPropertyName("emb_codes_debug_tags")]
    public string[] EmbCodesDebugTags { get; set; }
    
    [JsonPropertyName("emb_codes_orig")]
    public string EmbCodesOrig { get; set; }
    
    [JsonPropertyName("emb_codes_tags")]
    public string[] EmbCodesTags { get; set; }
    
    [JsonPropertyName("entry_dates_tags")]
    public string[] EntryDatesTags { get; set; }
    
    [JsonPropertyName("expiration_date")]
    public string ExpirationDate { get; set; }
    
    [JsonPropertyName("expiration_date_debug_tags")]
    public string[] ExpirationDateDebugTags { get; set; }
    
    [JsonPropertyName("fruits-vegetables-nuts_100g_estimate")]
    public int? FruitsVegetablesNuts100GEstimate { get; set; }
    
    [JsonPropertyName("generic_name")]
    public string GenericName { get; set; }
    
    [JsonPropertyName("image_front_small_url")]
    public string ImageFrontSmallUrl { get; set; }
    
    [JsonPropertyName("image_front_thumb_url")]
    public string ImageFrontThumbUrl { get; set; }
    
    [JsonPropertyName("image_front_url")]
    public string ImageFrontUrl { get; set; }
    
    [JsonPropertyName("image_ingredients_url")]
    public string ImageIngredientsUrl { get; set; }
    
    [JsonPropertyName("image_ingredients_small_url")]
    public string ImageIngredientsSmallUrl { get; set; }
    
    [JsonPropertyName("image_ingredients_thumb_url")]
    public string ImageIngredientsThumbUrl { get; set; }
    
    [JsonPropertyName("image_nutrition_small_url")]
    public string ImageNutritionSmallUrl { get; set; }
    
    [JsonPropertyName("image_nutrition_thumb_url")]
    public string ImageNutritionThumbUrl { get; set; }
    
    [JsonPropertyName("image_nutrition_url")]
    public string ImageNutritionUrl { get; set; }
    
    [JsonPropertyName("image_small_url")]
    public string ImageSmallUrl { get; set; }
    
    [JsonPropertyName("image_thumb_url")]
    public string ImageThumbUrl { get; set; }
    
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; }
    
    [JsonPropertyName("informers_tags")]
    public string[] InformersTags { get; set; }
    
    [JsonPropertyName("ingredients_analysis_tags")]
    public string[] IngredientsAnalysisTags { get; set; }
    
    [JsonPropertyName("ingredients_debug")]
    public string[] IngredientsDebug { get; set; }
    
    [JsonPropertyName("ingredients_from_or_that_may_be_from_palm_oil_n")]
    public int? IngredientsFromOrThatMayBeFromPalmOilN { get; set; }
    
    [JsonPropertyName("ingredients_from_palm_oil_tags")]
    public string[] IngredientsFromPalmOilTags { get; set; }
    
    [JsonPropertyName("ingredients_from_palm_oil_n")]
    public int? IngredientsFromPalmOilN { get; set; }
    
    [JsonPropertyName("ingredients_hierarchy")]
    public string[] IngredientsHierarchy { get; set; }
    
    [JsonPropertyName("ingredients_ids_debug")]
    public string[] IngredientsIdsDebug { get; set; }
    
    [JsonPropertyName("ingredients_n")]
    public int? IngredientsN { get; set; }
    
    [JsonPropertyName("ingredients_n_tags")]
    public string[] IngredientsNTags { get; set; }
    
    [JsonPropertyName("ingredients_original_tags")]
    public string[] IngredientsOriginalTags { get; set; }
    
    [JsonPropertyName("ingredients_tags")]
    public string[] IngredientsTags { get; set; }
    
    [JsonPropertyName("ingredients_text")]
    public string IngredientsText { get; set; }
    
    [JsonPropertyName("ingredients_text_debug")]
    public string IngredientsTextDebug { get; set; }
    
    [JsonPropertyName("ingredients_text_with_allergens")]
    public string IngredientsTextWithAllergens { get; set; }
    
    [JsonPropertyName("ingredients_that_may_be_from_palm_oil_n")]
    public int? IngredientsThatMayBeFromPalmOilN { get; set; }
    
    [JsonPropertyName("ingredients_that_may_be_from_palm_oil_tags")]
    public string[] IngredientsThatMayBeFromPalmOilTags { get; set; }
    
    [JsonPropertyName("interface_version_created")]
    public string InterfaceVersionCreated { get; set; }
    
    [JsonPropertyName("interface_version_modified")]
    public string InterfaceVersionModified { get; set; }
    
    [JsonPropertyName("_keywords")]
    public string[] Keywords { get; set; }
    
    [JsonPropertyName("known_ingredients_n")]
    public int? KnownIngredientsN { get; set; }
    
    [JsonPropertyName("labels_hierarchy")]
    public string[] LabelsHierarchy { get; set; }
    
    [JsonPropertyName("labels_lc")]
    public string LabelsLc { get; set; }
    
    [JsonPropertyName("labels_prev_hierarchy")]
    public string[] LabelsPrevHierarchy { get; set; }
    
    [JsonPropertyName("labels_prev_tags")]
    public string[] LabelsPrevTags { get; set; }
    
    [JsonPropertyName("labels_tags")]
    public string[] LabelsTags { get; set; }
    
    [JsonPropertyName("labels_debug_tags")]
    public string[] LabelsDebugTags { get; set; }
    
    [JsonPropertyName("lang_debug_tags")]
    public string[] LangDebugTags { get; set; }
    
    [JsonPropertyName("languages_hierarchy")]
    public string[] LanguagesHierarchy { get; set; }
    
    [JsonPropertyName("languages_tags")]
    public string[] LanguagesTags { get; set; }
    
    [JsonPropertyName("last_edit_dates_tags")]
    public string[] LastEditDatesTags { get; set; }
    
    [JsonPropertyName("last_editor")]
    public string LastEditor { get; set; }
    
    [JsonPropertyName("last_image_dates_tags")]
    public string[] LastImageDatesTags { get; set; }
    
    [JsonPropertyName("last_image_t")]
    public long? LastImageT { get; set; }
    
    [JsonPropertyName("last_modified_by")]
    public string LastModifiedBy { get; set; }
    
    [JsonPropertyName("last_modified_t")]
    public long? LastModifiedT { get; set; }
    
    [JsonPropertyName("link_debug_tags")]
    public string[] LinkDebugTags { get; set; }
    
    [JsonPropertyName("manufacturing_places")]
    public string ManufacturingPlaces { get; set; }
    
    [JsonPropertyName("manufacturing_places_debug_tags")]
    public string[] ManufacturingPlacesDebugTags { get; set; }
    
    [JsonPropertyName("manufacturing_places_tags")]
    public string[] ManufacturingPlacesTags { get; set; }
    
    // Changed from a string to a long to prevent:
    // System.InvalidOperationException : Cannot get the value of a token type 'Number' as a string.
    // And also allow scalability beyond 2,147,483,647 images (although unlikely)
    [JsonPropertyName("max_imgid")]
    public long MaxImgid { get; set; }

    [JsonPropertyName("minerals_prev_tags")]
    public string[] MineralsPrevTags { get; set; }
    
    [JsonPropertyName("minerals_tags")]
    public string[] MineralsTags { get; set; }
    
    [JsonPropertyName("misc_tags")]
    public string[] MiscTags { get; set; }
    
    [JsonPropertyName("net_weight_unit")]
    public string NetWeightUnit { get; set; }
    
    [JsonPropertyName("net_weight_value")]
    public string NetWeightValue { get; set; }
    
    [JsonPropertyName("nutrition_data_per")]
    public string NutritionDataPer { get; set; }
    
    [JsonPropertyName("nutrition_score_warning_no_fruits_vegetables_nuts")]
    public int? NutritionScoreWarningNoFruitsVegetablesNuts { get; set; }

    [JsonPropertyName("no_nutrition_data")]
    public string NoNutritionData { get; set; }

    // Changed from a string to an int to avoid:
    // System.InvalidOperationException : Cannot get the value of a token type 'Number' as a string.
    [JsonPropertyName("nova_group")]
    public int? NovaGroup { get; set; }
    
    [JsonPropertyName("nova_groups")]
    public string NovaGroups { get; set; }

    [JsonPropertyName("nova_group_debug")]
    public string NovaGroupDebug { get; set; }

    [JsonPropertyName("nova_group_tags")]
    public string[] NovaGroupTags { get; set; }
    
    [JsonPropertyName("nova_groups_tags")]
    public string[] NovaGroupsTags { get; set; }

    [JsonPropertyName("nucleotides_prev_tags")]
    public string[] NucleotidesPrevTags { get; set; }

    [JsonPropertyName("nucleotides_tags")]
    public string[] NucleotidesTags { get; set; }
    
    [JsonPropertyName("nutrient_levels_tags")]
    public string[] NutrientLevelsTags { get; set; }
    
    [JsonPropertyName("nutrition_data")]
    public string NutritionData { get; set; }
    
    [JsonPropertyName("nutrition_data_per_debug_tags")]
    public string[] NutritionDataPerDebugTags { get; set; }
    
    [JsonPropertyName("nutrition_data_prepared")]
    public string NutritionDataPrepared { get; set; }
    
    [JsonPropertyName("nutrition_data_prepared_per")]
    public string NutritionDataPreparedPer { get; set; }
    
    [JsonPropertyName("nutrition_grades")]
    public string NutritionGrades { get; set; }
    
    [JsonPropertyName("nutrition_score_beverage")]
    public int? NutritionScoreBeverage { get; set; }
    
    [JsonPropertyName("nutrition_score_debug")]
    public string NutritionScoreDebug { get; set; }
    
    [JsonPropertyName("nutrition_score_warning_no_fiber")]
    public int? NutritionScoreWarningNoFiber { get; set; }
    
    [JsonPropertyName("nutrition_grades_tags")]
    public string[] NutritionGradesTags { get; set; }
    
    [JsonPropertyName("origins_debug_tags")]
    public string[] OriginsDebugTags { get; set; }
    
    [JsonPropertyName("origins_tags")]
    public string[] OriginsTags { get; set; }
    
    [JsonPropertyName("other_information")]
    public string OtherInformation { get; set; }
    
    [JsonPropertyName("other_nutritional_substances_tags")]
    public string[] OtherNutritionalSubstancesTags { get; set; }
    
    [JsonPropertyName("packaging_debug_tags")]
    public string[] PackagingDebugTags { get; set; }
    
    [JsonPropertyName("ecoscore_data")]
    public EcoscoreData EcoscoreData { get; set; }
    
    [JsonPropertyName("packaging_tags")]
    public string[] PackagingTags { get; set; }
    
    [JsonPropertyName("photographers_tags")]
    public string[] PhotographersTags { get; set; }
    
    [JsonPropertyName("pnns_groups_1")]
    public string PnnsGroups1 { get; set; }
    
    [JsonPropertyName("pnns_groups_2")]
    public string PnnsGroups2 { get; set; }
    
    [JsonPropertyName("pnns_groups_1_tags")]
    public string[] PnnsGroups1Tags { get; set; }
    
    [JsonPropertyName("pnns_groups_2_tags")]
    public string[] PnnsGroups2Tags { get; set; }
    
    [JsonPropertyName("popularity_key")]
    public long? PopularityKey { get; set; }
    
    [JsonPropertyName("producer_version_id")]
    public string ProducerVersionId { get; set; }
    
    [JsonPropertyName("product_name")]
    public string ProductName { get; set; }
    
    // Changed from a string to an int to avoid:
    // System.InvalidOperationException : Cannot get the value of a token type 'Number' as a string.
    [JsonPropertyName("product_quantity")]
    public int ProductQuantity { get; set; }
    
    // Was missing in the original implementation of API v0 (now v3)
    [JsonPropertyName("product_quantity_unit")]
    public string ProductQuantityUnit { get; set; }
    
    [JsonPropertyName("purchase_places")]
    public string PurchasePlaces { get; set; }
    
    [JsonPropertyName("purchase_places_debug_tags")]
    public string[] PurchasePlacesDebugTags { get; set; }
    
    [JsonPropertyName("purchase_places_tags")]
    public string[] PurchasePlacesTags { get; set; }
    
    [JsonPropertyName("quality_tags")]
    public string[] QualityTags { get; set; }
    
    [JsonPropertyName("quantity_debug_tags")]
    public string[] QuantityDebugTags { get; set; }
    
    [JsonPropertyName("recycling_instructions_to_discard")]
    public string RecyclingInstructionsToDiscard { get; set; }
    
    [JsonPropertyName("serving_quantity")]
    public int ServingQuantity { get; set; }
    
    [JsonPropertyName("serving_size")]
    public string ServingSize { get; set; }
    
    [JsonPropertyName("serving_size_debug_tags")]
    public string[] ServingSizeDebugTags { get; set; }
    
    [JsonPropertyName("states_hierarchy")]
    public string[] StatesHierarchy { get; set; }
    
    [JsonPropertyName("states_tags")]
    public string[] StatesTags { get; set; }
    
    [JsonPropertyName("stores_debug_tags")]
    public string[] StoresDebugTags { get; set; }
    
    [JsonPropertyName("stores_tags")]
    public string[] StoresTags { get; set; }
    
    [JsonPropertyName("traces_from_ingredients")]
    public string TracesFromIngredients { get; set; }
    
    [JsonPropertyName("traces_hierarchy")]
    public string[] TracesHierarchy { get; set; }
    
    [JsonPropertyName("traces_debug_tags")]
    public string[] TracesDebugTags { get; set; }
    
    [JsonPropertyName("traces_from_user")]
    public string TracesFromUser { get; set; }
    
    [JsonPropertyName("traces_lc")]
    public string TracesLc { get; set; }
    
    [JsonPropertyName("traces_tags")]
    public string[] TracesTags { get; set; }
    
    [JsonPropertyName("unknown_ingredients_n")]
    public int? UnknownIngredientsN { get; set; }
    
    [JsonPropertyName("unknown_nutrients_tags")]
    public string[] UnknownNutrientsTags { get; set; }
    
    [JsonPropertyName("update_key")]
    public string UpdateKey { get; set; }
    
    [JsonPropertyName("vitamins_prev_tags")]
    public string[] VitaminsPrevTags { get; set; }
    
    [JsonPropertyName("vitamins_tags")]
    public string[] VitaminsTags { get; set; }
}