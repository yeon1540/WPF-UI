using System.Collections.Generic;

namespace Comm.sqlite.Interfaces
{
    public interface IDataBase<T> where T : class
    {
        #region 조회

        List<T> GetAll();

        /// <summary>
        /// 모든 데이터 조회
        /// </summary>
        /// <returns></returns>
        //List<T> Get();

        /// <summary>
        /// ID로 특정 데이터 조회
        /// </summary>
        /// <param name="sID"></param>
        /// <returns></returns>
        //T GetDetail(string sID);

        ///// <summary>
        ///// ID로 특정 데이터 조회
        ///// </summary>
        ///// <param name="sID"></param>
        ///// <returns></returns>
        //string GetData(string sID);

        ///// <summary>
        ///// ID기준으로 오름차순으로 리스트 가져오기
        ///// </summary>
        ///// <returns></returns>
        //List<T> AscOrderByGet();

        ///// <summary>
        ///// ID기준으로 내림차순으로 리스트 가져오기
        ///// </summary>
        ///// <returns></returns>
        //List<T> DesOrderByGet();

        #endregion

        #region 추가

        /// <summary>
        /// 데이터 추가
        /// </summary>
        /// <param name="entity"></param>
        //void Insert(string sID, string sData);

        #endregion

        #region 수정

        /// <summary>
        /// 데이터 업데이트
        /// </summary>
        /// <param name="entity"></param>
        //void Update(string sID, string sData);

        /// <summary>
        /// 데이터 업데이트
        /// </summary>
        /// <param name="sData"></param>
        //void Update(T sData);

        #endregion

        #region 삭제

        /// <summary>
        /// 특정 데이터 삭제
        /// </summary>
        /// <param name="sID"></param>
        //void Delete(string sID);

        #endregion
    }
}
