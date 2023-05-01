import React from 'react';

import cx from 'classnames';

type HeroListHeroTeamSelectorProps = {
  radiant: boolean;
  onClick?: () => void;
};

const HeroListHeroTeamSelector: React.FC<HeroListHeroTeamSelectorProps> = (props: HeroListHeroTeamSelectorProps) => {
  return (
    <div
      className={cx('opacity-0 cursor-pointer hover:opacity-50 w-1/2 h-full', {
        'bg-green-400': props.radiant,
        'bg-red-400': !props.radiant,
      })}
      onClick={props.onClick}
    ></div>
  );
};

export default HeroListHeroTeamSelector;
