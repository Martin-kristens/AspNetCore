//using Infrastrucutre.Factories;
//using Infrastrucutre.Models;
//using Infrastrucutre.Repositories;

//namespace Infrastrucutre.Services;

//public class FeaturesService(FeatureRepository featureRepository, FeatureItemRepository featureItemRepository)
//{
//    private readonly FeatureRepository _featureRepository = featureRepository;
//    private readonly FeatureItemRepository _featureItemRepository = featureItemRepository;

//    public async Task<ResponseResult> GetAllFeaturesAsync()
//    {
//		try
//		{
//            var result = await _featureRepository.GetAllAsync();
//            return result;
//		}
//		catch (Exception ex){ return ResponseFactory.Error(ex.Message);}
//    }
//}
