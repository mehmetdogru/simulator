// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: hm_tracker_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ObjectTrackMatcherConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ObjectTrackMatcherConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(4f)]
        public float max_match_dist
        {
            get { return __pbn__max_match_dist ?? 4f; }
            set { __pbn__max_match_dist = value; }
        }
        public bool ShouldSerializemax_match_dist()
        {
            return __pbn__max_match_dist != null;
        }
        public void Resetmax_match_dist()
        {
            __pbn__max_match_dist = null;
        }
        private float? __pbn__max_match_dist;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float bg_weight_location_dist
        {
            get { return __pbn__bg_weight_location_dist ?? 0f; }
            set { __pbn__bg_weight_location_dist = value; }
        }
        public bool ShouldSerializebg_weight_location_dist()
        {
            return __pbn__bg_weight_location_dist != null;
        }
        public void Resetbg_weight_location_dist()
        {
            __pbn__bg_weight_location_dist = null;
        }
        private float? __pbn__bg_weight_location_dist;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float bg_weight_direction_dist
        {
            get { return __pbn__bg_weight_direction_dist ?? 0f; }
            set { __pbn__bg_weight_direction_dist = value; }
        }
        public bool ShouldSerializebg_weight_direction_dist()
        {
            return __pbn__bg_weight_direction_dist != null;
        }
        public void Resetbg_weight_direction_dist()
        {
            __pbn__bg_weight_direction_dist = null;
        }
        private float? __pbn__bg_weight_direction_dist;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float bg_weight_bbox_size_dist
        {
            get { return __pbn__bg_weight_bbox_size_dist ?? 0f; }
            set { __pbn__bg_weight_bbox_size_dist = value; }
        }
        public bool ShouldSerializebg_weight_bbox_size_dist()
        {
            return __pbn__bg_weight_bbox_size_dist != null;
        }
        public void Resetbg_weight_bbox_size_dist()
        {
            __pbn__bg_weight_bbox_size_dist = null;
        }
        private float? __pbn__bg_weight_bbox_size_dist;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float bg_weight_point_num_dist
        {
            get { return __pbn__bg_weight_point_num_dist ?? 0f; }
            set { __pbn__bg_weight_point_num_dist = value; }
        }
        public bool ShouldSerializebg_weight_point_num_dist()
        {
            return __pbn__bg_weight_point_num_dist != null;
        }
        public void Resetbg_weight_point_num_dist()
        {
            __pbn__bg_weight_point_num_dist = null;
        }
        private float? __pbn__bg_weight_point_num_dist;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float bg_weight_histogram_dist
        {
            get { return __pbn__bg_weight_histogram_dist ?? 0f; }
            set { __pbn__bg_weight_histogram_dist = value; }
        }
        public bool ShouldSerializebg_weight_histogram_dist()
        {
            return __pbn__bg_weight_histogram_dist != null;
        }
        public void Resetbg_weight_histogram_dist()
        {
            __pbn__bg_weight_histogram_dist = null;
        }
        private float? __pbn__bg_weight_histogram_dist;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0.2f)]
        public float bg_weight_centroid_shift_dist
        {
            get { return __pbn__bg_weight_centroid_shift_dist ?? 0.2f; }
            set { __pbn__bg_weight_centroid_shift_dist = value; }
        }
        public bool ShouldSerializebg_weight_centroid_shift_dist()
        {
            return __pbn__bg_weight_centroid_shift_dist != null;
        }
        public void Resetbg_weight_centroid_shift_dist()
        {
            __pbn__bg_weight_centroid_shift_dist = null;
        }
        private float? __pbn__bg_weight_centroid_shift_dist;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0.8f)]
        public float bg_weight_bbox_iou_dist
        {
            get { return __pbn__bg_weight_bbox_iou_dist ?? 0.8f; }
            set { __pbn__bg_weight_bbox_iou_dist = value; }
        }
        public bool ShouldSerializebg_weight_bbox_iou_dist()
        {
            return __pbn__bg_weight_bbox_iou_dist != null;
        }
        public void Resetbg_weight_bbox_iou_dist()
        {
            __pbn__bg_weight_bbox_iou_dist = null;
        }
        private float? __pbn__bg_weight_bbox_iou_dist;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(4f)]
        public float bg_background_object_match_threshold
        {
            get { return __pbn__bg_background_object_match_threshold ?? 4f; }
            set { __pbn__bg_background_object_match_threshold = value; }
        }
        public bool ShouldSerializebg_background_object_match_threshold()
        {
            return __pbn__bg_background_object_match_threshold != null;
        }
        public void Resetbg_background_object_match_threshold()
        {
            __pbn__bg_background_object_match_threshold = null;
        }
        private float? __pbn__bg_background_object_match_threshold;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(0.6f)]
        public float fg_weight_location_dist
        {
            get { return __pbn__fg_weight_location_dist ?? 0.6f; }
            set { __pbn__fg_weight_location_dist = value; }
        }
        public bool ShouldSerializefg_weight_location_dist()
        {
            return __pbn__fg_weight_location_dist != null;
        }
        public void Resetfg_weight_location_dist()
        {
            __pbn__fg_weight_location_dist = null;
        }
        private float? __pbn__fg_weight_location_dist;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(0.2f)]
        public float fg_weight_direction_dist
        {
            get { return __pbn__fg_weight_direction_dist ?? 0.2f; }
            set { __pbn__fg_weight_direction_dist = value; }
        }
        public bool ShouldSerializefg_weight_direction_dist()
        {
            return __pbn__fg_weight_direction_dist != null;
        }
        public void Resetfg_weight_direction_dist()
        {
            __pbn__fg_weight_direction_dist = null;
        }
        private float? __pbn__fg_weight_direction_dist;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(0.1f)]
        public float fg_weight_bbox_size_dist
        {
            get { return __pbn__fg_weight_bbox_size_dist ?? 0.1f; }
            set { __pbn__fg_weight_bbox_size_dist = value; }
        }
        public bool ShouldSerializefg_weight_bbox_size_dist()
        {
            return __pbn__fg_weight_bbox_size_dist != null;
        }
        public void Resetfg_weight_bbox_size_dist()
        {
            __pbn__fg_weight_bbox_size_dist = null;
        }
        private float? __pbn__fg_weight_bbox_size_dist;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(0.1f)]
        public float fg_weight_point_num_dist
        {
            get { return __pbn__fg_weight_point_num_dist ?? 0.1f; }
            set { __pbn__fg_weight_point_num_dist = value; }
        }
        public bool ShouldSerializefg_weight_point_num_dist()
        {
            return __pbn__fg_weight_point_num_dist != null;
        }
        public void Resetfg_weight_point_num_dist()
        {
            __pbn__fg_weight_point_num_dist = null;
        }
        private float? __pbn__fg_weight_point_num_dist;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float fg_weight_histogram_dist
        {
            get { return __pbn__fg_weight_histogram_dist ?? 0.5f; }
            set { __pbn__fg_weight_histogram_dist = value; }
        }
        public bool ShouldSerializefg_weight_histogram_dist()
        {
            return __pbn__fg_weight_histogram_dist != null;
        }
        public void Resetfg_weight_histogram_dist()
        {
            __pbn__fg_weight_histogram_dist = null;
        }
        private float? __pbn__fg_weight_histogram_dist;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float fg_weight_centroid_shift_dist
        {
            get { return __pbn__fg_weight_centroid_shift_dist ?? 0f; }
            set { __pbn__fg_weight_centroid_shift_dist = value; }
        }
        public bool ShouldSerializefg_weight_centroid_shift_dist()
        {
            return __pbn__fg_weight_centroid_shift_dist != null;
        }
        public void Resetfg_weight_centroid_shift_dist()
        {
            __pbn__fg_weight_centroid_shift_dist = null;
        }
        private float? __pbn__fg_weight_centroid_shift_dist;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float fg_weight_bbox_iou_dist
        {
            get { return __pbn__fg_weight_bbox_iou_dist ?? 0f; }
            set { __pbn__fg_weight_bbox_iou_dist = value; }
        }
        public bool ShouldSerializefg_weight_bbox_iou_dist()
        {
            return __pbn__fg_weight_bbox_iou_dist != null;
        }
        public void Resetfg_weight_bbox_iou_dist()
        {
            __pbn__fg_weight_bbox_iou_dist = null;
        }
        private float? __pbn__fg_weight_bbox_iou_dist;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(100f)]
        public float bound_value
        {
            get { return __pbn__bound_value ?? 100f; }
            set { __pbn__bound_value = value; }
        }
        public bool ShouldSerializebound_value()
        {
            return __pbn__bound_value != null;
        }
        public void Resetbound_value()
        {
            __pbn__bound_value = null;
        }
        private float? __pbn__bound_value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KalmanFilterConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KalmanFilterConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0.1f)]
        public float noise_maximum
        {
            get { return __pbn__noise_maximum ?? 0.1f; }
            set { __pbn__noise_maximum = value; }
        }
        public bool ShouldSerializenoise_maximum()
        {
            return __pbn__noise_maximum != null;
        }
        public void Resetnoise_maximum()
        {
            __pbn__noise_maximum = null;
        }
        private float? __pbn__noise_maximum;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool use_adaptive
        {
            get { return __pbn__use_adaptive ?? false; }
            set { __pbn__use_adaptive = value; }
        }
        public bool ShouldSerializeuse_adaptive()
        {
            return __pbn__use_adaptive != null;
        }
        public void Resetuse_adaptive()
        {
            __pbn__use_adaptive = null;
        }
        private bool? __pbn__use_adaptive;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.4f)]
        public float centroid_measurement_noise
        {
            get { return __pbn__centroid_measurement_noise ?? 0.4f; }
            set { __pbn__centroid_measurement_noise = value; }
        }
        public bool ShouldSerializecentroid_measurement_noise()
        {
            return __pbn__centroid_measurement_noise != null;
        }
        public void Resetcentroid_measurement_noise()
        {
            __pbn__centroid_measurement_noise = null;
        }
        private float? __pbn__centroid_measurement_noise;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(5f)]
        public float centroid_init_velocity_variance
        {
            get { return __pbn__centroid_init_velocity_variance ?? 5f; }
            set { __pbn__centroid_init_velocity_variance = value; }
        }
        public bool ShouldSerializecentroid_init_velocity_variance()
        {
            return __pbn__centroid_init_velocity_variance != null;
        }
        public void Resetcentroid_init_velocity_variance()
        {
            __pbn__centroid_init_velocity_variance = null;
        }
        private float? __pbn__centroid_init_velocity_variance;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(10f)]
        public float propagation_variance_xy
        {
            get { return __pbn__propagation_variance_xy ?? 10f; }
            set { __pbn__propagation_variance_xy = value; }
        }
        public bool ShouldSerializepropagation_variance_xy()
        {
            return __pbn__propagation_variance_xy != null;
        }
        public void Resetpropagation_variance_xy()
        {
            __pbn__propagation_variance_xy = null;
        }
        private float? __pbn__propagation_variance_xy;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(10f)]
        public float propagation_variance_z
        {
            get { return __pbn__propagation_variance_z ?? 10f; }
            set { __pbn__propagation_variance_z = value; }
        }
        public bool ShouldSerializepropagation_variance_z()
        {
            return __pbn__propagation_variance_z != null;
        }
        public void Resetpropagation_variance_z()
        {
            __pbn__propagation_variance_z = null;
        }
        private float? __pbn__propagation_variance_z;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool use_convergence_boostup
        {
            get { return __pbn__use_convergence_boostup ?? false; }
            set { __pbn__use_convergence_boostup = value; }
        }
        public bool ShouldSerializeuse_convergence_boostup()
        {
            return __pbn__use_convergence_boostup != null;
        }
        public void Resetuse_convergence_boostup()
        {
            __pbn__use_convergence_boostup = null;
        }
        private bool? __pbn__use_convergence_boostup;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(3)]
        public int boostup_history_size_minimum
        {
            get { return __pbn__boostup_history_size_minimum ?? 3; }
            set { __pbn__boostup_history_size_minimum = value; }
        }
        public bool ShouldSerializeboostup_history_size_minimum()
        {
            return __pbn__boostup_history_size_minimum != null;
        }
        public void Resetboostup_history_size_minimum()
        {
            __pbn__boostup_history_size_minimum = null;
        }
        private int? __pbn__boostup_history_size_minimum;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(0.9f)]
        public float converged_confidence_minimum
        {
            get { return __pbn__converged_confidence_minimum ?? 0.9f; }
            set { __pbn__converged_confidence_minimum = value; }
        }
        public bool ShouldSerializeconverged_confidence_minimum()
        {
            return __pbn__converged_confidence_minimum != null;
        }
        public void Resetconverged_confidence_minimum()
        {
            __pbn__converged_confidence_minimum = null;
        }
        private float? __pbn__converged_confidence_minimum;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TrackerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TrackerConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"KalmanFilter")]
        public string filter_name
        {
            get { return __pbn__filter_name ?? @"KalmanFilter"; }
            set { __pbn__filter_name = value; }
        }
        public bool ShouldSerializefilter_name()
        {
            return __pbn__filter_name != null;
        }
        public void Resetfilter_name()
        {
            __pbn__filter_name = null;
        }
        private string __pbn__filter_name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool separate_fore_background
        {
            get { return __pbn__separate_fore_background ?? false; }
            set { __pbn__separate_fore_background = value; }
        }
        public bool ShouldSerializeseparate_fore_background()
        {
            return __pbn__separate_fore_background != null;
        }
        public void Resetseparate_fore_background()
        {
            __pbn__separate_fore_background = null;
        }
        private bool? __pbn__separate_fore_background;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class HmMultiTargetTrackerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public HmMultiTargetTrackerConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"KalmanFilter")]
        public string filter_method
        {
            get { return __pbn__filter_method ?? @"KalmanFilter"; }
            set { __pbn__filter_method = value; }
        }
        public bool ShouldSerializefilter_method()
        {
            return __pbn__filter_method != null;
        }
        public void Resetfilter_method()
        {
            __pbn__filter_method = null;
        }
        private string __pbn__filter_method;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"MultiHmBipartiteGraphMatcher")]
        public string foreground_mathcer_method
        {
            get { return __pbn__foreground_mathcer_method ?? @"MultiHmBipartiteGraphMatcher"; }
            set { __pbn__foreground_mathcer_method = value; }
        }
        public bool ShouldSerializeforeground_mathcer_method()
        {
            return __pbn__foreground_mathcer_method != null;
        }
        public void Resetforeground_mathcer_method()
        {
            __pbn__foreground_mathcer_method = null;
        }
        private string __pbn__foreground_mathcer_method;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"GnnBipartiteGraphMatcher")]
        public string background_matcher_method
        {
            get { return __pbn__background_matcher_method ?? @"GnnBipartiteGraphMatcher"; }
            set { __pbn__background_matcher_method = value; }
        }
        public bool ShouldSerializebackground_matcher_method()
        {
            return __pbn__background_matcher_method != null;
        }
        public void Resetbackground_matcher_method()
        {
            __pbn__background_matcher_method = null;
        }
        private string __pbn__background_matcher_method;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_histogram_for_match
        {
            get { return __pbn__use_histogram_for_match ?? true; }
            set { __pbn__use_histogram_for_match = value; }
        }
        public bool ShouldSerializeuse_histogram_for_match()
        {
            return __pbn__use_histogram_for_match != null;
        }
        public void Resetuse_histogram_for_match()
        {
            __pbn__use_histogram_for_match = null;
        }
        private bool? __pbn__use_histogram_for_match;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(10f)]
        public float histogram_bin_size
        {
            get { return __pbn__histogram_bin_size ?? 10f; }
            set { __pbn__histogram_bin_size = value; }
        }
        public bool ShouldSerializehistogram_bin_size()
        {
            return __pbn__histogram_bin_size != null;
        }
        public void Resethistogram_bin_size()
        {
            __pbn__histogram_bin_size = null;
        }
        private float? __pbn__histogram_bin_size;

    }

}

#pragma warning restore 0612, 1591, 3021