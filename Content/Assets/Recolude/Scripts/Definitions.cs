// This code was generated by: 
// https://github.com/recolude/swagger-unity-codegen
// Issues and PRs welcome :)

using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace Recolude
{

    [System.Serializable]
    public class ProtobufAny
    {

        public string type_url;

        public string value;

    }

    [System.Serializable]
    public class Resourcesv1License
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string description;

        public string id;

        public string name;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    [System.Serializable]
    public class RuntimeError
    {

        public int code;

        public ProtobufAny[] details;

        public string error;

        public string message;

    }

    [System.Serializable]
    public class V1ApiKey
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string description;

        public string id;

        public string name;

        public V1Permission[] permissions;

        public V1Project project;

        public string projectId;

        public string token;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    [System.Serializable]
    public class V1CustomEventCapture
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public string name;

        public V1Subject subject;

        public V1MetadataTag[] tags;

        public float time;

        public string trackableId;

        public string trackableType;

    }

    [System.Serializable]
    public class V1DevKey
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public V1Person person;

        public string personId;

        public string token;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    public enum V1EnumLifeCycle
    {
        LC_UNKNOWN,
        LC_START,
        LC_ENABLE,
        LC_DISABLE,
        LC_DESTROY
    }

    public enum V1EnumPermissionScope
    {
        PS_UNKNOWN,
        PS_GLOBAL,
        PS_ORGANIZATION,
        PS_PROJECT
    }

    public enum V1EnumProjectType
    {
        PT_UNKONWN,
        PT_PERSONAL,
        PT_ORGANIZATION
    }

    public enum V1EnumVisibility
    {
        V_UNKOWN,
        V_PUBLIC,
        V_PRIVATE
    }

    [System.Serializable]
    public class V1LifeCycleEventCapture
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public V1Subject subject;

        public string subjectId;

        public float time;

        public V1EnumLifeCycle type;

    }

    [System.Serializable]
    public class V1ListRecordingsRequest
    {

        public int limit;

        public int maxDate;

        public float maxDuration;

        public int maxEvents;

        public int maxSubjects;

        public int minDate;

        public float minDuration;

        public int minEvents;

        public int minSubjects;

        public string name;

        public int offset;

        public string order_by;

        public string organizationId;

        public string[] organizationIds;

        public string projectId;

        public string[] projectIds;

        public string searchString;

        public V1EnumVisibility visibility;

    }

    [System.Serializable]
    public class V1MetadataTag
    {

        public string content;

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public string name;

        public string trackableId;

        public string trackableType;

    }

    [System.Serializable]
    public class V1Organization
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string displayName;

        public string id;

        public Resourcesv1License license;

        public string licenseId;

        public string name;

        public V1Permission[] permissions;

        public V1Person[] persons;

        public V1Project[] projects;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    [System.Serializable]
    public class V1Permission
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public V1SecurityRole securityRole;

        public string securityRoleId;

        public string trackableEntityId;

        public string trackableEntityType;

        public string trackableGroupId;

        public string trackableGroupType;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    [System.Serializable]
    public class V1Person
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public V1DevKey devKey;

        public string email;

        public string id;

        public V1Organization[] organizations;

        public V1Permission[] permissions;

        public V1Project[] projects;

        public string sub;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

        public string username;

    }

    [System.Serializable]
    public class V1PositionCapture
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public V1Subject subject;

        public string subjectId;

        public float time;

        public float x;

        public float y;

        public float z;

    }

    [System.Serializable]
    public class V1Project
    {

        public V1Organization Organization;

        public V1ApiKey[] apiKeys;

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string description;

        public string id;

        public Resourcesv1License license;

        public string licenseId;

        public string name;

        public string organizationId;

        public V1Permission[] permissions;

        public V1Person[] persons;

        public V1Recording[] recordings;

        public V1EnumProjectType type;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

        public V1EnumVisibility visibility;

    }

    [System.Serializable]
    public class V1Recording
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public V1CustomEventCapture[] customEvents;

        public string id;

        public string name;

        public V1Project project;

        public string projectId;

        public V1Subject[] subjects;

        public V1RecordingSummary summary;

        public V1MetadataTag[] tags;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

        public V1EnumVisibility visibility;

    }

    [System.Serializable]
    public class V1RecordingResponse
    {

        public V1Recording recording;

    }

    [System.Serializable]
    public class V1RecordingSummary
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public int customEvents;

        public double duration;

        public string id;

        public string projectId;

        public int subjects;

        [SerializeField]
        private string uploadedAt;

        public System.DateTime UploadedAt { get => System.DateTime.Parse(uploadedAt); }

    }

    [System.Serializable]
    public class V1RecordingsResponse
    {

        public V1Recording[] recordings;

        public V1ListRecordingsRequest request;

        public int total_size;

    }

    [System.Serializable]
    public class V1RotationCapture
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string id;

        public V1Subject subject;

        public string subjectId;

        public float time;

        public float x;

        public float y;

        public float z;

    }

    [System.Serializable]
    public class V1SecurityGrant
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string description;

        public string id;

        public string name;

        public V1EnumPermissionScope scope;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    [System.Serializable]
    public class V1SecurityRole
    {

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public string description;

        public string id;

        public string name;

        public V1EnumPermissionScope scope;

        public V1SecurityGrant[] securityGrants;

        [SerializeField]
        private string updatedAt;

        public System.DateTime UpdatedAt { get => System.DateTime.Parse(updatedAt); }

    }

    [System.Serializable]
    public class V1Subject
    {

        public V1PositionCapture[] capturedPositions;

        public V1RotationCapture[] capturedRotations;

        [SerializeField]
        private string createdAt;

        public System.DateTime CreatedAt { get => System.DateTime.Parse(createdAt); }

        public V1CustomEventCapture[] customEvents;

        public string id;

        public V1LifeCycleEventCapture[] lifeCycleEvents;

        public int localId;

        public string name;

        public V1Recording recording;

        public string recordingId;

        public V1MetadataTag[] tags;

    }

}