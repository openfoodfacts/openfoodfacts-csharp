
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace pl.coderion.model
{
    public class Product
    {
        [JsonProperty("languages_codes")]
        public LanguagesCodes? languagesCodes { get; set; }
        [JsonProperty("nutrient_levels")]
        public NutrientLevels? nutrientLevels { get; set; }
        [JsonProperty("selected_images")]
        public SelectedImages? selectedImages { get; set; }
        [JsonProperty("additives_n")]
        public int? additivesN { get; set; }
        [JsonProperty("additives_old_n")]
        public int? additivesOldN { get; set; }
        [JsonProperty("additives_original_tags")]
        public String[]? additivesOriginalTags { get; set; }
        [JsonProperty("additives_old_tags")]
        public String[]? additivesOldTags { get; set; }
        [JsonProperty("additives_prev_original_tags")]
        public String[]? additivesPrevOriginalTags { get; set; }
        [JsonProperty("additives_debug_tags")]
        public String[]? additivesDebugTags { get; set; }
        [JsonProperty("additives_tags")]
        public String[]? additivesTags { get; set; }
        [JsonProperty("allergens_from_ingredients")]
        public string? allergensFromIngredients { get; set; }
        [JsonProperty("allergens_from_user")]
        public string? allergensFromUser { get; set; }
        [JsonProperty("allergens_hierarchy")]
        public String[]? allergensHierarchy { get; set; }
        [JsonProperty("allergens_lc")]
        public string? allergensLc { get; set; }
        [JsonProperty("allergens_tags")]
        public String[]? allergensTags { get; set; }
        [JsonProperty("amino_acids_prev_tags")]
        public String[]? aminoAcidsPrevTags { get; set; }
        [JsonProperty("amino_acids_tags")]
        public String[]? aminoAcidsTags { get; set; }
        public String? brands { get;set; }
        [JsonProperty("brands_debug_tags")]
        public String[]? brandsDebugTags { get; set; }
        [JsonProperty("brands_tags")]
        public String[]? brandsTags { get; set; }
        [JsonProperty("carbon_footprint_percent_of_known_ingredients")]
        public string? carbonFootprintPercentOfKnownIngredients { get; set; }
        [JsonProperty("carbon_footprint_from_known_ingredients_debug")]
        public string? carbonFootprintFromKnownIngredientsDebug { get; set; }
        [JsonProperty("categories_hierarchy")]
        public String[]? categoriesHierarchy { get; set; }
        [JsonProperty("categories_lc")]
        public string? categoriesLc { get; set; }
        [JsonProperty("categories_properties_tags")]
        public String[]? categoriesPropertiesTags { get; set; }
        [JsonProperty("categories_tags")]
        public String[]? categoriesTags { get; set; }
        [JsonProperty("checkers_tags")]
        public String[]? checkersTags { get; set; }
        [JsonProperty("cities_tags")]
        public String[]? citiesTags { get; set; }
        [JsonProperty("codes_tags")]
        public String[]? codesTags { get; set; }
        [JsonProperty("compared_to_category")]
        public string? comparedToCategory { get; set; }
        [JsonProperty("completed_t")]
        public long? completedT { get; set; }
        [JsonProperty("conservation_conditions")]
        public string? conservationConditions { get; set; }
        [JsonProperty("countries_hierarchy")]
        public String[]? countriesHierarchy { get; set; }
        [JsonProperty("countries_lc")]
        public string? countriesLc { get; set; }
        [JsonProperty("countries_debug_tags")]
        public String[]? countriesDebugTags { get; set; }
        [JsonProperty("countries_tags")]
        public String[]? countriesTags { get; set; }
        [JsonProperty("correctors_tags")]
        public String[]? correctorsTags { get; set; }
        [JsonProperty("created_t")]
        public long? createdT { get; set; }
        [JsonProperty("data_quality_bugs_tags")]
        public String[]? dataQualityBugsTags { get; set; }
        [JsonProperty("data_quality_errors_tags")]
        public String[]? dataQualityErrorsTags { get; set; }
        [JsonProperty("data_quality_info_tags")]
        public String[]? dataQualityInfoTags { get; set; }
        [JsonProperty("data_quality_tags")]
        public String[]? dataQualityTags { get; set; }
        [JsonProperty("data_quality_warnings_tags")]
        public String[]? dataQualityWarningsTags { get; set; }
        [JsonProperty("data_sources")]
        public string? dataSources { get; set; }
        [JsonProperty("data_sources_tags")]
        public String[]? dataSourcesTags { get; set; }
        [JsonProperty("debug_param_sorted_langs")]
        public String[]? debugParamSortedLangs { get; set; }
        [JsonProperty("editors_tags")]
        public String[]? editorsTags { get; set; }
        [JsonProperty("emb_codes")]
        public string? embCodes { get; set; }
        [JsonProperty("emb_codes_debug_tags")]
        public String[]? embCodesDebugTags { get; set; }
        [JsonProperty("emb_codes_orig")]
        public string? embCodesOrig { get; set; }
        [JsonProperty("emb_codes_tags")]
        public String[]? embCodesTags { get; set; }
        [JsonProperty("entry_dates_tags")]
        public String[]? entryDatesTags { get; set; }
        [JsonProperty("expiration_date")]
        public string? expirationDate { get; set; }
        [JsonProperty("expiration_date_debug_tags")]
        public String[]? expirationDateDebugTags { get; set; }
        [JsonProperty("fruits-vegetables-nuts_100g_estimate")]
        public int? fruitsVegetablesNuts100GEstimate { get; set; }
        [JsonProperty("generic_name")]
        public string? genericName { get; set; }
        [JsonProperty("image_front_small_url")]
        public string? imageFrontSmallUrl { get; set; }
        [JsonProperty("image_front_thumb_url")]
        public string? imageFrontThumbUrl { get; set; }
        [JsonProperty("image_front_url")]
        public string? imageFrontUrl { get; set; }
        [JsonProperty("image_ingredients_url")]
        public string? imageIngredientsUrl { get; set; }
        [JsonProperty("image_ingredients_small_url")]
        public string? imageIngredientsSmallUrl { get; set; }
        [JsonProperty("image_ingredients_thumb_url")]
        public string? imageIngredientsThumbUrl { get; set; }
        [JsonProperty("image_nutrition_small_url")]
        public string? imageNutritionSmallUrl { get; set; }
        [JsonProperty("image_nutrition_thumb_url")]
        public string? imageNutritionThumbUrl { get; set; }
        [JsonProperty("image_nutrition_url")]
        public string? imageNutritionUrl { get; set; }
        [JsonProperty("image_small_url")]
        public string? imageSmallUrl { get; set; }
        [JsonProperty("image_thumb_url")]
        public string? imageThumbUrl { get; set; }
        [JsonProperty("image_url")]
        public string? imageUrl { get; set; }
        [JsonProperty("informers_tags")]
        public String[]? informersTags { get; set; }
        [JsonProperty("ingredients_analysis_tags")]
        public String[]? ingredientsAnalysisTags { get; set; }
        [JsonProperty("ingredients_debug")]
        public String[]? ingredientsDebug { get; set; }
        [JsonProperty("ingredients_from_or_that_may_be_from_palm_oil_n")]
        public int? ingredientsFromOrThatMayBeFromPalmOilN { get; set; }
        [JsonProperty("ingredients_from_palm_oil_tags")]
        public String[]? ingredientsFromPalmOilTags { get; set; }
        [JsonProperty("ingredients_from_palm_oil_n")]
        public int? ingredientsFromPalmOilN { get; set; }
        [JsonProperty("ingredients_hierarchy")]
        public String[]? ingredientsHierarchy { get; set; }
        [JsonProperty("ingredients_ids_debug")]
        public String[]? ingredientsIdsDebug { get; set; }
        [JsonProperty("ingredients_n")]
        public int? ingredientsN { get; set; }
        [JsonProperty("ingredients_n_tags")]
        public String[]? ingredientsNTags { get; set; }
        [JsonProperty("ingredients_original_tags")]
        public String[]? ingredientsOriginalTags { get; set; }
        [JsonProperty("ingredients_tags")]
        public String[]? ingredientsTags { get; set; }
        [JsonProperty("ingredients_text")]
        public string? ingredientsText { get; set; }
        [JsonProperty("ingredients_text_debug")]
        public string? ingredientsTextDebug { get; set; }
        [JsonProperty("ingredients_text_with_allergens")]
        public string? ingredientsTextWithAllergens { get; set; }
        [JsonProperty("ingredients_that_may_be_from_palm_oil_n")]
        public int? ingredientsThatMayBeFromPalmOilN { get; set; }
        [JsonProperty("ingredients_that_may_be_from_palm_oil_tags")]
        public String[]? ingredientsThatMayBeFromPalmOilTags { get; set; }
        [JsonProperty("interface_version_created")]
        public string? interfaceVersionCreated { get; set; }
        [JsonProperty("interface_version_modified")]
        public string? interfaceVersionModified { get; set; }
        [JsonProperty("_keywords")]
        public String[]? keywords { get; set; }
        [JsonProperty("known_ingredients_n")]
        public int? knownIngredientsN { get; set; }
        [JsonProperty("labels_hierarchy")]
        public String[]? labelsHierarchy { get; set; }
        [JsonProperty("labels_lc")]
        public string? labelsLc { get; set; }
        [JsonProperty("labels_prev_hierarchy")]
        public String[]? labelsPrevHierarchy { get; set; }
        [JsonProperty("labels_prev_tags")]
        public String[]? labelsPrevTags { get; set; }
        [JsonProperty("labels_tags")]
        public String[]? labelsTags { get; set; }
        [JsonProperty("labels_debug_tags")]
        public String[]? labelsDebugTags { get; set; }
        [JsonProperty("lang_debug_tags")]
        public String[]? langDebugTags { get; set; }
        [JsonProperty("languages_hierarchy")]
        public String[]? languagesHierarchy { get; set; }
        [JsonProperty("languages_tags")]
        public String[]? languagesTags { get; set; }
        [JsonProperty("last_edit_dates_tags")]
        public String[]? lastEditDatesTags { get; set; }
        [JsonProperty("last_editor")]
        public string? lastEditor { get; set; }
        [JsonProperty("last_image_dates_tags")]
        public String[]? lastImageDatesTags { get; set; }
        [JsonProperty("last_image_t")]
        public long? lastImageT { get; set; }
        [JsonProperty("last_modified_by")]
        public string? lastModifiedBy { get; set; }
        [JsonProperty("last_modified_t")]
        public long? lastModifiedT { get; set; }
        [JsonProperty("link_debug_tags")]
        public String[]? linkDebugTags { get; set; }
        [JsonProperty("manufacturing_places")]
        public string? manufacturingPlaces { get; set; }
        [JsonProperty("manufacturing_places_debug_tags")]
        public String[]? manufacturingPlacesDebugTags { get; set; }
        [JsonProperty("manufacturing_places_tags")]
        public String[]? manufacturingPlacesTags { get; set; }
        [JsonProperty("max_imgid")]
        public string? maxImgid { get; set; }
        [JsonProperty("minerals_prev_tags")]
        public String[]? mineralsPrevTags { get; set; }
        [JsonProperty("minerals_tags")]
        public String[]? mineralsTags { get; set; }
        [JsonProperty("misc_tags")]
        public String[]? miscTags { get; set; }
        [JsonProperty("net_weight_unit")]
        public string? netWeightUnit { get; set; }
        [JsonProperty("net_weight_value")]
        public string? netWeightValue { get; set; }
        [JsonProperty("nutrition_data_per")]
        public string? nutritionDataPer { get; set; }
        [JsonProperty("nutrition_score_warning_no_fruits_vegetables_nuts")]
        public int? nutritionScoreWarningNoFruitsVegetablesNuts { get; set; }
        [JsonProperty("no_nutrition_data")]
        public string? noNutritionData { get; set; }
        [JsonProperty("nova_group")]
        public string? novaGroup { get; set; }
        [JsonProperty("nova_groups")]
        public string? novaGroups { get; set; }
        [JsonProperty("nova_group_debug")]
        public string? novaGroupDebug { get; set; }
        [JsonProperty("nova_group_tags")]
        public String[]? novaGroupTags { get; set; }
        [JsonProperty("nova_groups_tags")]
        public String[]? novaGroupsTags { get; set; }
        [JsonProperty("nucleotides_prev_tags")]
        public String[]? nucleotidesPrevTags { get; set; }
        [JsonProperty("nucleotides_tags")]
        public String[]? nucleotidesTags { get; set; }
        [JsonProperty("nutrient_levels_tags")]
        public String[]? nutrientLevelsTags { get; set; }
        [JsonProperty("nutrition_data")]
        public string? nutritionData { get; set; }
        [JsonProperty("nutrition_data_per_debug_tags")]
        public String[]? nutritionDataPerDebugTags { get; set; }
        [JsonProperty("nutrition_data_prepared")]
        public string? nutritionDataPrepared { get; set; }
        [JsonProperty("nutrition_data_prepared_per")]
        public string? nutritionDataPreparedPer { get; set; }
        [JsonProperty("nutrition_grades")]
        public string? nutritionGrades { get; set; }
        [JsonProperty("nutrition_score_beverage")]
        public int? nutritionScoreBeverage { get; set; }
        [JsonProperty("nutrition_score_debug")]
        public string? nutritionScoreDebug { get; set; }
        [JsonProperty("nutrition_score_warning_no_fiber")]
        public int? nutritionScoreWarningNoFiber { get; set; }
        [JsonProperty("nutrition_grades_tags")]
        public String[]? nutritionGradesTags { get; set; }
        [JsonProperty("origins_debug_tags")]
        public String[]? originsDebugTags { get; set; }
        [JsonProperty("origins_tags")]
        public String[]? originsTags { get; set; }
        [JsonProperty("other_information")]
        public string? otherInformation { get; set; }
        [JsonProperty("other_nutritional_substances_tags")]
        public String[]? otherNutritionalSubstancesTags { get; set; }
        [JsonProperty("packaging_debug_tags")]
        public String[]? packagingDebugTags { get; set; }
        [JsonProperty("packaging_tags")]
        public String[]? packagingTags { get; set; }
        [JsonProperty("photographers_tags")]
        public String[]? photographersTags { get; set; }
        [JsonProperty("pnns_groups_1")]
        public string? pnnsGroups1 { get; set; }
        [JsonProperty("pnns_groups_2")]
        public string? pnnsGroups2 { get; set; }
        [JsonProperty("pnns_groups_1_tags")]
        public String[]? pnnsGroups1Tags { get; set; }
        [JsonProperty("pnns_groups_2_tags")]
        public String[]? pnnsGroups2Tags { get; set; }
        [JsonProperty("popularity_key")]
        public long? popularityKey { get; set; }
        [JsonProperty("producer_version_id")]
        public string? producerVersionId { get; set; }
        [JsonProperty("product_name")]
        public string? productName { get; set; }
        [JsonProperty("product_quantity")]
        public string? productQuantity { get; set; }
        [JsonProperty("purchase_places")]
        public string? purchasePlaces { get; set; }
        [JsonProperty("purchase_places_debug_tags")]
        public String[]? purchasePlacesDebugTags { get; set; }
        [JsonProperty("purchase_places_tags")]
        public String[]? purchasePlacesTags { get; set; }
        [JsonProperty("quality_tags")]
        public String[]? qualityTags { get; set; }
        [JsonProperty("quantity_debug_tags")]
        public String[]? quantityDebugTags { get; set; }
        [JsonProperty("recycling_instructions_to_discard")]
        public string? recyclingInstructionsToDiscard { get; set; }
        [JsonProperty("serving_quantity")]
        public string? servingQuantity { get; set; }
        [JsonProperty("serving_size")]
        public string? servingSize { get; set; }
        [JsonProperty("serving_size_debug_tags")]
        public String[]? servingSizeDebugTags { get; set; }
        [JsonProperty("states_hierarchy")]
        public String[]? statesHierarchy { get; set; }
        [JsonProperty("states_tags")]
        public String[]? statesTags { get; set; }
        [JsonProperty("stores_debug_tags")]
        public String[]? storesDebugTags { get; set; }
        [JsonProperty("stores_tags")]
        public String[]? storesTags { get; set; }
        [JsonProperty("traces_from_ingredients")]
        public string? tracesFromIngredients { get; set; }
        [JsonProperty("traces_hierarchy")]
        public String[]? tracesHierarchy { get; set; }
        [JsonProperty("traces_debug_tags")]
        public String[]? tracesDebugTags { get; set; }
        [JsonProperty("traces_from_user")]
        public string? tracesFromUser { get; set; }
        [JsonProperty("traces_lc")]
        public string? tracesLc { get; set; }
        [JsonProperty("traces_tags")]
        public String[]? tracesTags { get; set; }
        [JsonProperty("unknown_ingredients_n")]
        public int? unknownIngredientsN { get; set; }
        [JsonProperty("unknown_nutrients_tags")]
        public String[]? unknownNutrientsTags { get; set; }
        [JsonProperty("update_key")]
        public string? updateKey { get; set; }
        [JsonProperty("vitamins_prev_tags")]
        public String[]? vitaminsPrevTags { get; set; }
        [JsonProperty("vitamins_tags")]
        public String[]? vitaminsTags { get; set; }
    }
}
